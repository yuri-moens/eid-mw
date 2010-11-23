package be.fedict.eidviewer.gui;

import be.fedict.eid.applet.service.Address;
import be.fedict.eid.applet.service.Identity;
import be.fedict.eidviewer.lib.Eid;
import java.awt.Image;
import java.util.Observable;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author frank
 */
public class EidController extends Observable implements Runnable
{

    private boolean                 mRunning = false;
    private Eid                     mEid;
    private STATE                   mState;
    private ACTIVITY                mActivity;
    private Identity                mIdentity;
    private Address                 mAddress;
    private Image                   mPhoto;

    private void clearCardInformation()
    {
        mIdentity=null;
        mAddress=null;
        mPhoto=null;
    }

    public static enum STATE
    { 
        IDLE("state_idle"), ERROR("state_error"), NO_READERS("state_noreaders"), NO_EID_PRESENT("state_noeidpresent"),EID_PRESENT("state_eidpresent");

        private final String state;
        private STATE(String state) { this.state = state; }
        @Override
        public String toString() { return this.state; }
    };

    public static enum ACTIVITY
    {
         IDLE("activity_idle"), READING_IDENTITY("reading_identity"), READING_ADDRESS("reading_address"), READING_PHOTO("reading_photo");

        private final String state;
        private ACTIVITY(String state) { this.state = state; }
        @Override
        public String toString() { return this.state; }
    }

    public EidController(Eid eid)
    {
        mEid = eid;
        setState(STATE.IDLE);
        setActivity(ACTIVITY.IDLE);
    }

    private void setState(STATE newState)
    {
        mState=newState;
        setState();
    }

    private void setActivity(ACTIVITY newActivity)
    {
        mActivity=newActivity;
        setState();
    }

    private void setState()
    {
        setChanged();
        notifyObservers();
    }

    public void start()
    {
        new Thread(this).start();
    }

    public void stop()
    {
        mRunning = false;
    }

    public void run()
    {
        mRunning = true;
        while(mRunning)
        {
            try
            {
                if(!mEid.hasCardReader())
                {
                    setState(STATE.NO_READERS);
                    mEid.waitForCardReader();
                }

                if(!mEid.isEidPresent())
                {
                    setState(STATE.NO_EID_PRESENT);
                    mEid.waitForEidPresent();
                }
          
                setState(STATE.EID_PRESENT);
                
                setActivity(ACTIVITY.READING_IDENTITY);
                mIdentity=mEid.getIdentity();
                setState();

                setActivity(ACTIVITY.READING_ADDRESS);
                mAddress=mEid.getAddress();
                setState();

                setActivity(ACTIVITY.READING_PHOTO);
                mPhoto=mEid.getPhoto();
                setState();
                setActivity(ACTIVITY.IDLE);

                mEid.removeCard();
                clearCardInformation();
            }
            catch(Exception ex)
            {
                clearCardInformation();
                setState(STATE.ERROR);  
                Logger.getLogger(EidController.class.getName()).log(Level.SEVERE, null, ex);

                try
                {
                    Thread.sleep(1000);
                }
                catch (InterruptedException ex1)
                {
                    Logger.getLogger(EidController.class.getName()).log(Level.SEVERE, null, ex1);
                }
                
                setState(STATE.IDLE);
            }
        }
    }

    public Address getAddress()
    {
        return mAddress;
    }

    public Identity getIdentity()
    {
        return mIdentity;
    }

    public Image getPhoto()
    {
        return mPhoto;
    }

    public STATE getState()
    {
        return mState;
    }

    public ACTIVITY getActivity()
    {
        return mActivity;
    }
    
    public boolean hasAddress()
    {
        return (mAddress!=null);
    }

    public boolean hasIdentity()
    {
        return (mIdentity!=null);
    }

    public boolean hasPhoto()
    {
        return (mPhoto!=null);
    }
}