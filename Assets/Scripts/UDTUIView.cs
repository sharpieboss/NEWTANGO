/*============================================================================== 
 * Copyright (c) 2012-2013 Qualcomm Connected Experiences, Inc. All Rights Reserved. 
 * ==============================================================================*/
using UnityEngine;
using System.Collections;

public class UDTUIView : UIView {
    
    #region PUBLIC_PROPERTIES
    public CameraDevice.FocusMode FocusMode
    {
        get {
            return m_focusMode;
        }
        set {
            m_focusMode = value;
        }
    }
    #endregion PUBLIC_PROPERTIES
    
    #region PUBLIC_MEMBER_VARIABLES
    public event System.Action TappedToClose;
    public UIBox mBox;
    public UILabel mHeaderLabel;
    public UICheckButton mAboutLabel;
    public UICheckButton mExtendedTracking;
    public UICheckButton mCameraFlashSettings;
    public UICheckButton mAutoFocusSetting;
    public UILabel mCameraLabel;
    public UIRadioButton mCameraFacing;
    public UIButton mCloseButton;

    #endregion PUBLIC_MEMBER_VARIABLES
    
    #region PRIVATE_MEMBER_VARIABLES
    private CameraDevice.FocusMode m_focusMode;
    #endregion PRIVATE_MEMBER_VARIABLES
    
    #region PUBLIC_METHODS
    
    public void LoadView()
    {
        mBox = new UIBox(UIConstants.BoxRect, UIConstants.MainBackground);
        
        mHeaderLabel = new UILabel(UIConstants.RectLabelOne, UIConstants.UDTTextureStyle);
        
        string[] aboutStyles = { UIConstants.AboutLableStyle, UIConstants.AboutLableStyle };
        mAboutLabel = new UICheckButton(UIConstants.RectLabelAbout, false, aboutStyles);
        
        string[] extendedTrackingStyles = { UIConstants.ExtendedTrackingStyleOff, UIConstants.ExtendedTrackingStyleOn };
        mExtendedTracking = new UICheckButton(UIConstants.RectOptionOne, false, extendedTrackingStyles);
        
        string[] cameraFlashStyles = {UIConstants.CameraFlashStyleOff, UIConstants.CameraFlashStyleOn};
        mCameraFlashSettings = new UICheckButton(UIConstants.RectOptionThree, false, cameraFlashStyles);
        
        string[] autofocusStyles = {UIConstants.AutoFocusStyleOff, UIConstants.AutoFocusStyleOn};
        mAutoFocusSetting = new UICheckButton(UIConstants.RectOptionTwo, false, autofocusStyles);
        
        mCameraLabel = new UILabel(UIConstants.RectLabelTwo, UIConstants.CameraLabelStyle);
        
        string[,] cameraFacingStyles = new string[2,2] {{UIConstants.CameraFacingFrontStyleOff, UIConstants.CameraFacingFrontStyleOn},{ UIConstants.CameraFacingRearStyleOff, UIConstants.CameraFacingRearStyleOn}};
        UIRect[] cameraRect = { UIConstants.RectOptionFour, UIConstants.RectOptionFive };
        mCameraFacing = new UIRadioButton(cameraRect, 1, cameraFacingStyles);
        
        string[] closeButtonStyles = {UIConstants.closeButtonStyleOff, UIConstants.closeButtonStyleOn };
        mCloseButton = new UIButton(UIConstants.CloseButtonRect, closeButtonStyles);

//      Rect rect = new Rect(0.4f * Screen.width, Screen.height - (100 * Screen.width)/800.0f, 0.3f * Screen.width, (70.0f * Screen.width)/800.0f);
//      string[] newUDTButtonStyles = {"UserInterface/capture_button_normal_XHigh", "UserInterface/capture_button_normal_XHigh"};
//      string imageForButton = "UserInterface/icon_camera";
//      mNewUserDefinedTargetButton = new UIButton(rect, newUDTButtonStyles, imageForButton);
    }

    public void UnLoadView()
    {
        mHeaderLabel = null;
        mAboutLabel = null;
        mExtendedTracking = null;
        mCameraFlashSettings = null;
        mAutoFocusSetting = null;
        mCameraLabel = null;
        mCameraFacing = null;
    }
    
    public void UpdateUI(bool tf)
    {
        if(!tf)
        {
            return;
        }
        
        mBox.Draw();
        mAboutLabel.Draw();
        mHeaderLabel.Draw();
        mExtendedTracking.Draw();
        mCameraFlashSettings.Draw();
        mAutoFocusSetting.Draw();
        mCameraLabel.Draw();
        mCameraFacing.Draw();
        mCloseButton.Draw();

    }

    public void OnTappedToClose ()
    {
        if(this.TappedToClose != null)
        {
            this.TappedToClose();
        }
    }
    #endregion PUBLIC_METHODS
}

