----------------------------------------------
            NGUI: Next-Gen UI kit
 Copyright © 2011-2012 Tasharen Entertainment
                Version 2.6.2
    http://www.tasharen.com/?page_id=197
            support@tasharen.com
----------------------------------------------

Thank you for buying NGUI!

If you have any questions, suggestions, comments or feature requests, please
drop by the NGUI forum, found here: http://www.tasharen.com/forum/index.php?board=1.0

--------------------
 How To Update NGUI
--------------------

If you have the Professional Edition of NGUI that comes with Git access, just pull the latest changes.

If you have a Standard Edition:

1. In Unity, File -> New Scene
2. Delete the NGUI folder from the Project View.
3. Import NGUI from the updated Unity Package.

---------------------------------------
 Support, documentation, and tutorials
---------------------------------------

All can be found here: http://www.tasharen.com/?page_id=197

Using NGUI with JavaScript (UnityScript)? Read this first: http://www.tasharen.com/forum/index.php?topic=6

-----------------
 Version History
-----------------

2.6.2:
- NEW: You can now automatically apply alpha pre-multiplication to textures when creating an atlas.
- NEW: Added UIWidget.Raycast to perform a raycast without using colliders.
- NEW: Added a texture preview to UITexture.
- NEW: Added an option to UIAnchor to run only once, and then destroy itself. Also optimized it slightly.
- NEW: Transform inspector will now gray out fields that are not commonly used by the UI when a widget is selected.
- FIX: Transform multi-object editing was not quite right for widgets...
- FIX: "Shrink to fit" option on labels now works vertically, not just horizontally.
- FIX: Changing a sprite in inspector will no longer auto-resize it. Use MakePixelPerfect to resize it.

2.6.1:
- FIX: Dynamic font-related fixes.
- FIX: Depth pass will now be force-disabled when the panel is clipped.
- FIX: Sticky press option on the UICamera no longer breaks OnDrop events.
- FIX: UIInput's useLabelTextAtStart should now work again.
- FIX: UICamera.touchCount should now be accurate.
- FIX: Fixed a typo in the image button inspector.
- FIX: UIWidget.UpdateGeometry will now check for object's disabled state prior to filling the geometry.

2.6.0
- NEW: Added dynamic font support for Unity 4.0.
- NEW: Handles can now be toggled on/off from the NGUI menu.
- NEW: Atlas maker will now be limited by max texture size, and will no longer make it possible to corrupt an atlas.
- NEW: Warning will be shown on the panel if clipping is not possible (GLES 1.1).
- NEW: Checkbox can now have fade in the checkmark instantly.
- NEW: You can now leave C++ style comments (//) in the localization files.
- NEW: You can now paste into input fields in stand-alone builds.
- NEW: Added disabled state to UIImageButton (Nicki)
- FIX: UISlider will now use the sprite size rather than collider size to determine the touch effect area.
- FIX: Resetting the tween will now mark it as not started.
- FIX: Blank labels will no longer be localized.
- FIX: Resetting the sprite animation will also reset the sprite back to 0.

2.5.1
- NEW: Added a "shrink to fit" option for labels that will scale down the text if it doesn't fit.
- FIX: Re-added the "import font" field in the font inspector.

2.5.0
- DEL: Deprecated Unity 3.5.4 and earlier support. If you are using 3.5.4 or earlier, DO NOT UPDATE!
- OLD: Sliced, tiled, and filled sprites have been deprecated.
- NEW: Regular sprite now has options for how the sprite is drawn.
- NEW: NGUI widgets now have visual placement handles.
- NEW: Adding a widget now automatically creates a UI hierarchy if one is not present.
- NEW: NGUI menu has been redesigned with new options and shortcut keys.
- FIX: Widget selection box now takes padding into account properly.
- FIX: Changing the pivot no longer moves the widget visually.
- FIX: Font symbols now use padding instead of inner rect for offset.
- FIX: Font symbols no longer need to be used in the editor before they are usable in-game.
- FIX: More fixes to how tweens get initialized/started.
- FIX: Re-added UISlider.fullSize property for better backwards compatibility.
- FIX: Unity 4.1-related fixes.
- FIX: Variety of other minor tweaks and changes.

2.3.6
- NEW: Added a much easier way to add symbols and emoticons (select the font, you will see it).
- NEW: Added a couple of conditional warnings to the UIPanel warning of common mistakes.
- NEW: Various improvements to widget and sprite inspectors.
- FIX: There is no need to display the "symbols" option on the labels if the font doesn't have any.
- FIX: Removed the hard-coded screen height-based touch threshold on the UICamera.
- FIX: Removed the need for sliders to have a "full size" property.

2.3.5:
- NEW: Font symbols can now have an offset for easier positioning.
- FIX: UISlider will now set the 'current' property before calling the delegate.
- FIX: Fixed the checkbox animation issue that was brought to light as a result of 2.3.4.
- FIX: Minor other tweaks, nothing important.

2.3.4:
- NEW: Added the ability to easily copy/paste widget colors in the inspector.
- FIX: Random fixes for minor issues noted on the forums.
- FIX: Minor performance improvements.

2.3.3
- NEW: UIPanels now have alpha for easy fading, and TweenAlpha can now tween panels.
- NEW: Added UICamera.debug mode for when you want to know what the mouse is hovering over.
- NEW: Added AnimatedColor and AnimatedAlpha scripts in case you want to animate widget color or alpha via Unity's animations.
- NEW: Android devices should now be able to support a keyboard and a controller (OUYA).
- NEW: Added UIFont.pixelSize, making it possible to have HD/UD fonts that are not a part of an atlas.
- FIX: Unity 4.1 optimization fix.
- FIX: Label shadow should now be affected by alpha using PMA shaders.
- FIX: UICheckbox.current will now work correctly for checkbox event receivers.
- FIX: UIButton series of scripts should now initialize themselves on start, not when they are used.
- FIX: TweenOrthoSize should now tween the size instead of FOV (o_O).
- FIX: Sprite selection window will now show sprites properly when the atlas is not square.
- FIX: UIAnchor should now always maintain the same Z-depth, and once again works in 3D UIs.

2.3.1
- NEW: Added UICamera.touchCount.
- NEW: Added an option on the UIInput to turn on auto-correction on mobiles.
- FIX: Fixed compilation on Unity 3.
- FIX: Font inspector will now display the font in a preview window.

2.3.0:
- NEW: Added Premultiplied Alpha support to NGUI along with the appropriate shaders.
- NEW: Added UIButtonKeyBinding script that makes it easy to do button key bindings.
- NEW: Transform inspector now supports multi-object editing (contribution by Bardelot 'Cripple' Alexandre)
- NEW: UIRoot's 'automatic' flag is now gone, replaced by a more intuitive drop-down list.
- NEW: It's now possible to make UIRoot fixed size on mobiles, but pixel-perfect on desktops (it's an option).
- NEW: You can now specify an animation curve on all tweens.
- NEW: Localization will now attempt to load the starting language automatically.
- NEW: Added UICamera.onCustomInput callback making it possible to add input form custom devices.
- NEW: Support for optimizations in Unity 4.1.
- FIX: Tweaks to Localization to make it easier to use. You can now just do Localization.Localize everywhere.
- FIX: UILocalize attached to a label used by input will now localize its default value instead.
- FIX: Kerning should now get saved properly. You will need to re-import your fonts.
- FIX: UICamera with multi-touch turned off should now work properly when returning from sleep.
- FIX: ActiveAnimation's onFinished callback will no longer wait for all animation states to finish (only the playing one).
- FIX: UICamera's touch detection should now work properly when returning from sleep.
- FIX: Changed the way MakePixelPerfect works a bit, hopefully fixing an issue with sprites moving by a pixel.
- FIX: UIPanel should now display the clipped rectangle correctly.
- FIX: UIInputSaved will now save on submit.
- DEL: Removed UIAnchor.depthOffset seeing as it caused more confusion than anything else. Just use an offset child GameObject.
- DEL: Deprecated hard clipping, seeing as it causes issues on too many devices.

2.2.7:
- NEW: Added UICamera.stickyPress option that makes it possible for multiple objects to receive OnPress notifications from a single touch.
- NEW: UICamera.hoveredObject now works for touch events as well, and will always hold the result of the last Raycast.
- NEW: Added "Edit" buttons to all atlase and font fields, making easy to select the atlas/font for modification.
- NEW: Added Localization.Localize. Was going to change Localization.Get to be static, but didn't want to break backwards compatibility.
- FIX: Inventory example should work correctly in Unity 4.0.
- FIX: You can now set UILabel.text to null.
- FIX: UIPanel was not drawing its rect correctly in some cases.
- FIX: Assortment of tweaks and fixes submitted by Andrew Osborne (community contribution).
- FIX: Switching a mainTexture of a UITexture belonging to a clipped panel will now work properly.

2.2.6:
- NEW: Mouse and touch events now have an option to be clipped by the panel's clipping rect, just like widgets.
- NEW: Made it possible to delete several sprites at once (Atlas Maker).
- FIX: Added proper support for Unity 4-based nested active state while maintaining backwards compatibility.

2.2.5:
- NEW: Double-clicking a sprite in the sprite selection window will now close the window.
- FIX: UIRoot will now only consider min/max clamping in automatic mode.
- FIX: Password fields should now get wrapped properly.
- FIX: MakePixelPerfect() will now preserve negatives.
- FIX: UISlider will no longer jump to 0 when clicked with the controller.

2.2.4:
- NEW: SpringPanel and UICenterOnChild now have an OnFinished callback.
- NEW: UIForwardEvents now has OnScroll.
- FIX: UISavedOption now unregisters the state change delegate when disabled.
- FIX: IgnoreTimeScale clamps time delta at 1 sec maximum, fixing a long pause after returning from sleep.
- FIX: UIWidget now correctly cleans up UITextures that have been re-parented.
- FIX: Tween scripts now sample the tween immediately if the duration is 0.
- FIX: UIFont and UIAtlas MarkAsDirty() function now works correctly with a reference atlas (in the editor).

2.2.3:
- FIX: Small fix for UIAnchor using a clipped panel container (thanks yuewah!)
- FIX: Work-around/fix-ish thing for Unity Remote sending both mouse and touch events.
- FIX: hideInactive on UIGrid should now function correctly.

2.2.2:
- NEW: You can now specify a minimum and maximum height on UIRoot.
- NEW: Label shadow and outline distance can now be modified.
- NEW: Added UIButtonActivate -- an extremely simple script that can be used to activate or deactivate something on click.
- NEW: Creating a new UI will now automatically add a kinematic rigidbody to the UIRoot, as it's supposedly faster for physics checks.
- NEW: Game objects destroyed via NGUITools.Destroy will now automatically get un-parented.
- NEW: UIEventListener now has an OnKey delegate.
- FIX: Sprite preview should now display wide sprites correctly.
- FIX: Fixed copy/paste error in the atlas inspector (thanks athos!).
- FIX: UIGrid will no longer consider destroyed game objects.
- FIX: Couple of other smaller fixes.

2.2.1:
- FIX: Sprite list should now be faster.
- FIX: Sprite border editing should now work properly again.
- FIX: A couple of other minor fixes.

2.2.0:
- NEW: Added a sprite selection window that replaces the drop-down selection list. Think texture selection window for your sprites. The sprite selection window has a search box to narrow down your selection.
- NEW: Sprite preview is now shown in the Preview window, and is affected by the widget's color tint.
- NEW: Added warning messages when more than one widget is using the same depth value, and when more than one atlas is used by the panel.
- NEW: It's now possible to edit a sprite quickly by choosing the "edit" option.
- NEW: When editing a sprite in the atlas, a "Return to ..." button is shown if you've navigated here from a sprite.
- FIX: UIAnchor and UIStretch now work with labels properly.
- FIX: UITexture will no longer occasionally lose the reference to its texture.
- FIX: NGUITools.EncodeColor now works in Flash (created a work-around).

2.1.6:
- NEW: UISavedOption now works on a popup list as well.
- FIX: Replaced ifdefs for Unity 4 with a new helper functions for cleaner code (NGUITools.GetActive and NGUITools.SetActiveSelf).
- FIX: UITable was not properly keeping the contents within the draggable panel.
- FIX: UIDraggablePanel.UpdateScrollbars was not considering soft clipping properly, resulting in some jitterness.
- FIX: SpringPanel was not setting position / clipping when it finished, resulting in floating-point drifting errors.
- FIX: UIInput's "not selected" text can now be localized using UILocalize.

2.1.5:
- NEW: Added support for Unity 4.
- NEW: NGUI now uses Unity 3.5.5's newly-added Color32 for colors instead of Color, reducing the memory bandwidth a bit.
- NEW: UIStretch can now stretch to another widget's bounds, not just the screen.
- FIX: UIImageButton will no longer add a box collider if a non-box collider is present.
- FIX: NGUITools.ParseSymbol will now check to see if the symbol is valid.
- FIX: UITexture-related tweaks to UIWidget.
- FIX: UIAnchor can now anchor to labels.
- FIX: UISlicedSprite no longer uses padding.

2.1.4:
- NEW: UIInput now supports multi-line input if its label is multi-line. Hold Ctrl when hitting Enter.
- FIX: UICheckboxControlledComponent will now use delegates by default.
- FIX: UITexture should now work properly again.

2.1.3:
- NEW: Seeing as it was an often-asked question, the Scroll View example now features a toggle that makes the scrolled list center on items.
- NEW: UIAnchor can now anchor to sides of other widgets and panels.
- NEW: UICamera now has "drag threshold" properties. Drag events will only be sent after this threshold has been exceeded.
- NEW: You no longer have to create a material for the UITexture.
- NEW: You can now specify a UV rect for the UITexture if you only wish to display a part of it.
- NEW: All event senders, tweens and animation components now have a delegate callback you can use instead of the SendMessage-based event receiver.
- NEW: Added UICamera.current and UIPopupList.current.
- NEW: SpringPosition now has "on finished" event notifications (both event receiver and delegate).
- NEW: Added a new script that can be used to change the alpha of an entire panel worth of widgets at once: UIPanelAlpha.
- FIX: Replaced most usages of List with BetterList instead in order to significantly reduce memory allocation.
- FIX: Custom texture packer now respects padding correctly.

2.1.2:
- NEW: Selected widgets now show their panel's bounding rect, which is the screen's rect if the panel isn't clipped.
- FIX: Tweens that have not been added dynamically will start playing correctly.
- FIX: Texture packer should now have better packing logic.

2.1.1:
- NEW: New texture packer, alternative to using Unity's built-in one. Default is still Unity for backwards compatibilty.
- NEW: Added a different line wrapping functionality for input fields contributed by MightyM.
- NEW: UILocalize now has a "Localize" function you can trigger to make it force-localize whatever it's on.
- NEW: UITweener now has an option to not ignore timeScale.
- FIX: Fixed a "drifting panel" issue introduced in the last update.
- FIX: Added a warning for slider thumb used with radially filled sliders (not supported).
- FIX: ActiveAnimation will now clear its event receiver and callback on Play.
- FIX: UISpriteAnimation.isDone is now UISpriteAnimation.isPlaying, and is no longer backwards.

2.1.0:
- NEW: Now maintained under Unity 3.5.3.
- NEW: BetterList now has Insert and Contains functions.
- NEW: UITweener now has bounce style tweening methods.
- NEW: UITweener's OnUpdate function now has "isFinished" parameter that's set to 'true' if it's the last update.
- NEW: TweenTransform is now capable of re-parenting the object when finished.
- NEW: Added TweenVolume that can tween an audio source's volume.
- NEW: UICamera now has a new property: "Generic Event Handler". If set, this object will receive a copy of all events regardless of where they go.
- NEW: Widget Wizard now lets you specify an initial pivot point for sprites.
- NEW: UISpriteAnimation now has an option to not loop the animation anymore, and can tell you how many frames it has.
- NEW: Added TweenFOV that can be used to tween camera's field of view.
- NEW: Added a UISoundVolume script that can change the volume of the sounds used by NGUITools.PlaySound when attached to a slider.
- FIX: UIInput will now bring up a proper password keyboard on touch-based devices.
- FIX: UIImageButton will now set the correct sprite when it's enabled while highlighted.
- FIX: DragDropItem example script will now work on touch-based devices.
- FIX: UIButtonPlayAnimation will now clear the event receiver if none was specified.
- FIX: Various changes to UICamera, making it more touch-device friendly.
- FIX: UIPanels marked as static will now update their geometry when new widgets get added.
- FIX: Shaders no longer use "fixed" data type as it seems to have issues on certain devices.
- DEL: Removed old deprecated functions in order to clean up the code.

2.0.9:
- NEW: UITable can now return its list of children (in sorted order) via UITable.children.
- FIX: UISpriteAnimation can now be paused with FPS of 0.
- FIX: UITweener's delay should now work properly.
- FIX: UIPanel should now create draw calls with "dont destroy on load" flag instead of hideflags at run time, resolving a rare warning.
- FIX: Tweaks to how multi-touches are handled when they're disabled.
- FIX: Removed the "#pragma fragmentoption ARB_precision_hint_fastest" which was causing issues due to no support on android, mac mini's and possibly other devices.
- FIX: UIInput carat should be removed upon leaving the field on iOS.
- FIX: UIInput default text should be removed OnSelect on iOS.
- FIX: Inventory example should no longer have its own menu, but will instead be under NGUI.

2.0.8:
- NEW: Packed fonts now have clipped version of shaders, making them work with clipped panels.
- NEW: You can now specify the maximum number of lines on UILabel instead of just multiline / single line option.
- NEW: UIButton's disabled color can now be specified explicitly.
- NEW: Tweens and animations now have OnDoubleClick and OnSelect events to work with as well.
- NEW: It's now possible to control the volume used by all UI sounds: NGUITools.soundVolume.
- NEW: You can now delay a tween by specifying a start time delay.
- NEW: You can now disable multi-touch on UICamera, making all touches be treated as one.
- NEW: MakePixelPerfect is now in NGUITools, not NGUIMenu.
- FIX: UIImageButton won't switch images anymore if the script is disabled.
- FIX: Starting value in Localization will no longer overwrite the explicitly switched languages.

2.0.7:
- NEW: You can now specify what keyboard type will be used on mobile devices.
- NEW: You can now add input validation to your inputs to exclude certain characters (such as make your input numeric-only).
- FIX: Packed fonts no longer tie up the alpha channel, and can now be affected by alpha just fine.
- FIX: Clipped panels will no longer cause the unused material message in the console.
- FIX: 3D UIs should now be created with a proper anchor offset.
- FIX: UISliderColors will now work for more than 3 colors.
- FIX: UIPanel will no longer cause a null exception at run time.

2.0.6:
- NEW: Added support for fonts packed into separate RGBA channels (read: eastern language fonts can now be 75% smaller).
- NEW: UITooltip is now a part of NGUI's core rather than being in examples, allowing you to use it freely.
- NEW: Submit and cancel keys can now be specified on the UICamera (before they were hardcoded to Return and Escape).
- FIX: Unity should no longer crash when a second widget is added to the same game object.
- FIX: UIDrawCall no longer updates the index buffer unless it needs to, resulting in increased performance.
- FIX: UIDrawCall now uses double-buffering, so iOS performance should increase.
- FIX: You can now specify whether symbols are affected by color or not (or if they're processed for that matter).
- FIX: Fixed an issue with highlighting not returning to highlighted state after press.

2.0.5:
- NEW: Added support for custom-defined symbols (emoticons and such) in fonts.
- NEW: Added NGUI menu -> Make Pixel Perfect (Alt+Shift+P), and NGUI Menu -> Add Collider is now Alt+Shift+C.
- NEW: Added OnActivate condition to tweens and active animations.
- NEW: It's now possible to have a UITable position items upwards instead of downwards.
- NEW: It's now possible to have a "sticky" tooltip specified on UICamera, making it easier for tooltips to show up.
- NEW: UIInput will now send out OnInputChanged notifications when typing.
- NEW: Added TweenVolume script you can use to tween AudioSource's volume.
- FIX: Fixed what was causing the "Cleaning up leaked objects in scene" message to show up.

2.0.4:
- NEW: Added UIButton -- same as UIButtonColor, but has a disabled state.
- NEW: Added the OnDoubleClick event. Same as OnClick, just sent on double-click.
- FIX: UIDraggablePanel should now have noticeably better performance with many widgets.
- FIX: All private serializable properties will now be hidden from the inspector.
- FIX: UITooltip is now more robust and automatically uses background border size for padding.
- FIX: UILabel inspector now uses a word-wrapped textbox.
- FIX: UIButtonPlayAnimation and UIButtonTween now have an event receiver (on finished).
- FIX: UIGrid no longer modifies Z of its items on reposition.
- FIX: Only one Localization class is now allowed to be present.
- FIX: UILabel should now have a bit better performance in the editor.
- FIX: UISprite's MakePixelPerfect setting now takes padding into account properly.

2.0.3:
- NEW: UIButtonSound now allows you to specify pitch in addition to volume.
- FIX: UIDraggablePanel will now update the scroll bars on start.
- FIX: UITweenScale will now start with a scale of one instead of zero by default.
- FIX: UIInput will now ignore all characters lower than space, fixing an issue with mac OS input.
- FIX: UITexture will no longer lose its material whenever something changes.
- FIX: Reworked the way the mouse is handled in UICamera, fixing a couple of highlighting issues.

2.0.2:
- FIX: UIButton series of scripts will now correctly disable and re-enable their selected state when the game object is enabled / disabled.
- FIX: SpringPanel will now notify the Draggable Panel script on movement, letting it update scroll bars correctly.
- FIX: UIDraggablePanel will now lose its momentum every frame rather than only when it's being dragged.
- FIX: UIDraggablePanel will no longer reset the panel's position on start.
- FIX: UIDraggablePanel.ResetPosition() now functions correctly.
- FIX: UIDraggablePanel.UpdateScrollbars() will now only adjust the position if the scroll bars aren't being updated (ie: called from a scroll bar).
- FIX: 3D UIs will now be created with a proper anchor offset.

2.0.1:
- NEW: UIDraggablePanel will now display the bounds of the draggable widgets as an orange outline in the Scene View.
- NEW: Added a 'repositionNow' checkbox to UIDraggablePanel that will reset the clipping area using the children widget's current bounds.
- NEW: It's now possible to specify horizontal and vertical axis names for UICamera.
- FIX: UICamera will no longer process WASD or Space key events if an Input Field is currently selected.
- FIX: UIDraggablePanel's 'startingDragAmount' was renamed to 'startingRelativePosition', for clarity.
- FIX: UICheckbox will now set the checkmark state immediately on start instead of gradually.
- FIX: UISlider will now always force-set its value value on start.
- FIX: UIInput.text will now always return its own text rather than that of the label (works better with captions).
- FIX: Setting UIInput.text now sets the color of the label to the active color.

2.0.0:
- NEW: Redesigned the way UIDragCamera and UIDragPanelContents work, making them much more straightforward.
- NEW: New widget has been added: Scroll Bar. It does exactly what you think it does.
- NEW: UIDraggableCamera script is used on the camera to make it draggable via UIDragCamera.
- NEW: UIDraggablePanel script is used on the panel to make it draggable via UIDragPanelContents.
- NEW: UIDraggablePanel natively supports scroll bars with "always show", "fade out if not needed" and "fade in only when dragging" behaviors.
- NEW: Scroll View (DragPanel) and Quest Log examples have been updated with scroll bars.
- NEW: Reorganized all examples to be in a more logical order -- starting with the basic, common functionality and going up from there.
- NEW: Localization will now try to automatically load the language file via Resources.Load if it wasn't found in the local list.
- NEW: Atlas Maker tool now allows you to turn off trimming of transparent pixels before importing certain sprites.
- NEW: Atlas Maker tool now allows you to specify how much padding is applied in-between of sprites.
- FIX: EditorPrefs are now used instead of PlayerPrefs to store editor-related data.
- FIX: Popup list will no longer try to call SendMessage in edit mode.
- FIX: UIEventListener.Add is now UIEventListener.Get, making the function make more sense with the -= operator.
- DEL: Scroll View example that was using UIDragObject has been removed as it's now obsolete.

1.92:
- NEW: Expanded the Filled Sprite to support radial-based filling. Great for progress indicators, cooldown timers, circular health bars, etc.
- FIX: Eliminated all runtime uses of 'foreach', seeing as it causes memory leaks on iOS.

1.91:
- NEW: Added a new example scene showing how to easily implement drag & drop from 2D UI to the 3D world.
- FIX: UICamera was sending multiple OnDrag events for the mouse. This has now been fixed.
- FIX: UIAnchor changes in 1.90 had a few adverse effects on two of the examples.

1.90:
- NEW: You can now specify an option on the UIDragPanelContents that will prevent dragging if the contents already fit.
- NEW: You can now specify a radio button group root on the checkbox instead of always having it be the parent object.
- NEW: You can now easily adjust the widget's alpha by using the new UIWidget.alpha property.
- NEW: UIAnchor script has been redesigned, and the 'stretch to fill' property has been removed. You can now position using relative coordinates.
- NEW: UIStretch script has been added, allowing you to stretch an object in either (or both) directions using relative coordinates.
- NEW: You can now specify a maximum range distance for UICamera's raycasts, allowing you to limit the interaction distance (for first-person cameras).
- FIX: Popup list inspector now shows the "Position" drop-down.
- FIX: Slider now updates correctly when it's first created, and when you change the Full Size property.
- FIX: UIDragCamera now takes the camera's size into consideration.
- FIX: DestroyImmediate calls have been replaced with NGUITools.DestroyImmediate as there seem to be odd issues on certain Android devices.

1.88:
- NEW: Added an option to the tweener to use steeper pow(2) curves for ease in/out tweens.
- NEW: You can now specify the movement threshold that will be used to determine whether button presses are eligible for clicks on UICamera.
- NEW: You can now specify an input field to be password-based, and it will only hide the text once you start typing.
- FIX: UIButtonTween can now disable objects properly after a toggle.
- FIX: UISavedOption can now save the state of a single checkbox in addition to a group of checkboxes.
- FIX: Localization now handles duplicate key entries silently.
- FIX: Widgets not using a texture will now have gizmos.
- FIX: Fix for the OnClick event on touch-based devices.

1.87:
- NEW: UISlider now has an inspector class, and 'rawValue' can no longer be modified (use 'sliderValue'!)
- FIX: An assortment of tweaks and fixes, focusing on stability and ease of use.
- FIX: Reworked the way the UIPopupList was calculating its padding, making it more robust.
- FIX: Disabled widgets will get updated correctly when the atlas gets replaced.
- FIX: Disabling the button on click should no longer make it get stuck in the "clicked" state.
- FIX: UICamera.lastTouchPosition is back.

1.86:
- NEW: UIAtlas now has a "pixel size" property that affects MakePixelPerfect logic as well as sliced sprite's border size.
- FIX: UISprite will now always ensure it has a sprite to work with, if at all possible.
- FIX: UIDragPanelContents should now work correctly on mobile devices.

1.85:
- NEW: Added Example 12: Better Scroll View.
- NEW: Added a script that can be used to efficiently drag the contents of the panel: UIDragPanelContents.
- NEW: Added a function replacement for SetActiveRecursively (NGUITools.SetActive), since the former has rare odd issues.

1.84:
- FIX: Changed the way the font data is stored, resulting in potentially better loading performance on mobile devices.
- FIX: UIPanel.Start() should now find cameras faster.
- FIX: UIPanel will no longer use the clipping softness value unless soft clipping is actually used.
- FIX: The way click / drag was handled has been changed a bit. It should now be easier to click buttons on retina screens.
- FIX: Rebuilding an atlas was not updating fonts correctly.
- FIX: Couple of tweaks to UIAtlas and UIFont's replacement feature.

1.83:
- NEW: Added a simple script that can save the state of the checkbox (or a group of checkboxes) to player prefs.
- FIX: A variety of minor tweaks.

1.82:
- NEW: It's now possible to specify a "replacement" value on UIAtlas and UIFonts, making swapping of atlases and fonts a trivial matter.
- NEW: UICheckbox now has an option to allow unchecking the last item within a group.
- FIX: Most cases of FindObjectsOfTypeAll has been replaced with FindSceneObjectsOfType instead.
- FIX: UISliderColors now keeps the slider's alpha.
- FIX: Edit-time modification of UISlider's 'rawValue' in the inspector will now again visibly move the slider.
- FIX: UIWidget will no longer consider its geometry as changed every frame if there is nothing to draw (empty text labels).
- FIX: Atlas Maker will now create a new font if the name of the font doesn't match.
- OLD: NGUITools.ReplaceAtlas and Font functions have been deprecated.

1.81:
- NEW: UIInput can now be multi-line.
- FIX: UILabel will now center-align properly again when a fixed line width was specified.
- FIX: UILabel's effect (shadow, outline) will now be affected by the label's alpha.
- FIX: UILabel's effect will now always be offset consistently, even if the scale changes.
- FIX: Changing the widget's pivot will no longer cause it to become it pixel-perfect.
- FIX: UISlider no longer requires a box collider.
- FIX: Creating sliders via the wizard will now set their full size property.

1.80:
- NEW: You can now add a colored shadow/bevel or an outline effect to your labels via a simple checkbox.
- NEW: UICamera now has support for keyboard, joystick and controller input.
- NEW: UICamera can now control what kind of events it will process (only touch, only keyboard, etc).
- NEW: UISlider can now be adjusted via keyboard, joystick and controller input.
- NEW: UIPopupList can now be interacted with using a keyboard or controller input.
- NEW: Added a new script, UIButtonKeys that can be used to set up the UI for keyboard, joystick and controller input.
- NEW: New Example 11 shows how to set up the UI to work with the new input types.

1.70:
- NEW: Right click stuff has been replaced by just 'lastTouchID' with added support for the middle mouse button.
- NEW: UIDragCamera now has scrolling wheel support just like UIDragObject.
- FIX: UTF8 encoding is not supported in Flash. Wrote my own binary parsing function to make Flash work.
- FIX: UILabel will now align to right and center properly when not pixel-perfect.
- FIX: UIFont.WrapText will now trim away space characters when word wrapping.
- FIX: UIFont.Print will no longer draw spaces (padding will still be applied).
- FIX: UIPopupList will highlight the correct item even when localized.
- FIX: UITable will now handle disabled children properly.
- FIX: Fixed a crash on Unity 3.5.0 (sigh!).
- FIX: Tweaked how pixel-perfect calculations work for labels.

1.69:
- NEW: Added right-click support by simply adding an optional integer parameter to the OnClick event.
- NEW: The contents of the UIPopupList can now be localized by enabling a checkbox on it.
- NEW: You can now give the UIEventListener an optional parameter that you can retrieve later.

1.68:
- NEW: Added a built-in Localization System.
- NEW: Added a new example (10) - Localization.
- FIX: Widgets can now be modified directly on prefabs.
- FIX: Fixed the window stuttering in example 9 (when dragging it).
- FIX: Widgets will now ensure they're under the right panel after drag & drop in the editor.
- FIX: It's now possible to visibly modify the value of the slider at edit mode.
- FIX: Scaling labels now properly rebuilds them.
- FIX: Scaling labels will no longer affect the widget bounds in odd ways.

1.67:
- FIX: Font Maker's Replace button will now re-import the data file.
- FIX: Fixed all known issues with Undo functionality.
- FIX: Fixed all known issues with prefabs (mainly 3.5.0-related)
- FIX: Fixed clipping in Flash by adding a work-around for a bug in Flash export.
- FIX: Removed 3.5b6 work-arounds for Flash as the bug has since been fixed.

1.66:
- NEW: Added a new script: ShaderQuality. It's used to automatically set shader level of detail as the quality level goes down.
- FIX: All examples have been updated to run properly in Flash.
- FIX: NGUI now has no warnings using Unity 3.5.0.

1.65:
- NEW: Example 9: Quest Log shows how to make a fancy quest log.
- NEW: Added a new feature to UIPanel -- the ability to write to depth before any geometry is drawn. This doubles the draw calls but saves fillrate.
- NEW: Clicking on the items in the panel and camera tools will now select them instead of enable/disable them.
- NEW: UITable can now automatically keep its contents within the parent panel's bounds.
- NEW: New event type: OnScroll(float delta).
- FIX: FindInChildren was not named properly. It's now FindInParents.
- FIX: Eliminated most warnings on Unity 3.5.

1.64:
- NEW: Atlas inspector window now shows "Dimensions" and "Border" instead of "Outer" and "Inner" rects.
- NEW: UIPanel now has an optional property: "showInPanelTool" that determines whether the panel will show up in the Panel Tool.
- FIX: Trimmed sprite-using fonts will now correctly trim the glyphs.
- FIX: The "inner rect" outline now uses a checker texture, making it visible regardless of sprite's color.
- FIX: Selected sprite within the UIAtlas is now persistent.
- FIX: Panel and Camera tools have been improved with additional functionality.

1.63:
- NEW: Added a logo to all examples with some additional shiny functionality (contributed by Hjupter Cerrud).
- NEW: Label template in the Widget Tool now has a default color that will be applied to newly created labels.
- NEW: Added an option to TweenScale to automatically notify the UITable of the change.
- FIX: Updating a texture atlas saved as a non-PNG image will now update the texture correctly.
- FIX: Updating an atlas with a font sprite in it will now correctly mark all fonts using it as dirty.
- FIX: Fixed all remaining known issues with the Atlas Maker.
- FIX: Tiled Sprite will now use an inner rect rather than outer rect, letting you add some padding.
- FIX: UIButtonTween components will now set their target in Awake() rather than Start(), fixing a rare order-of-execution issue.
- FIX: UITable will now consider the item's own local scale when calculating bounds.
- DEL: "Deprecated" folder has been deleted.

1.62:
- NEW: Added a new class -- UITable -- that can be used to organize its children into rows/columns of variable size (think HTML table).
- FIX: Font Maker will make it more obvious when you are going to overwrite a font.
- FIX: Tweener will now set its timestamp on Start(), making tweens that start playing on Play behave correctly.
- FIX: UISlicedSprite will now notice that its scale is changing and will rebuild its geometry properly.
- FIX: Atlas and Font maker will now create new atlases and fonts in the same folder as the selected items.

1.61:
- NEW: UICheckbox.current will hold the checkbox that triggered the 'functionName' function on the 'eventReceiver'.
- FIX: UIPopupList will now place the created object onto a proper layer.

1.60:
- NEW: Added a built-in atlas-making solution: Atlas Maker, making it possible to create atlases without leaving Unity.
- NEW: Added a tool that makes creation of fonts easier: Font Maker. Works well with the Atlas Maker.
- FIX: UIAtlasInspector will now always force the atlas texture to be of proper size whenever the material or texture packer import gets triggered.
- FIX: Removed the work-around for Flash that disabled sound, seeing the bug has been since fixed.
- FIX: Tweener has been renamed to NTweener to avoid name conflicts with HOTween.
- FIX: An assortment of minor usability tweaks.

1.50:
- NEW: The UI is now timeScale-independent, letting you pause the game via Time.timeScale = 0.
- NEW: Added an UpdateManager class that can be used to programmatically control the order of script updates.
- NEW: NGUITools.PlaySound() now returns an AudioSource, letting you change the pitch.
- FIX: UIAtlas and UIFont now work with Textures instead of Texture2Ds, letting you use render textures.
- FIX: Typewriter effect script will now pre-wrap text before printing it.
- FIX: NGUIEditorTools.SelectedRoot() no longer considers prefabs to be valid.
- FIX: TexturePacker import will automatically strip out the ".png" extension from script names.
- FIX: Tested and working with the Flash export as of 3.5.0 f3.

1.49:
- NEW: UIWidgets now work with Textures rather than Texture2D, making it possible to use render textures if desired.
- FIX: Rewrote the UIFont's WrapText function. It now supports wrapping of long lines properly.
- FIX: Input fields are now multi-line, and will now show the last line when typing past the label's width.
- FIX: Input fields will now update less frequently when IME or iOS/Android keyboard is used.

1.48:
- NEW: Added a new container class -- BetterList<>. It replaced the generic List<> in many cases, eliminating GC spikes.
- FIX: Various performance-related optimizations.
- FIX: UITextList will now handle resized text labels correctly.
- FIX: Parenting and reparenting widgets will now cause their panel to get updated correctly.
- FIX: Eliminated one potential cause of widgets trying to update before being parented.

1.47:
- NEW: Added a new example (8) showing how to create a simple menu system.
- NEW: Added an example script that adds a typewriter effect to labels.
- NEW: Added a 'text scale' property to the UIPopupList.
- FIX: UIPopupList will now choose a more appropriate depth rather than just a high number.
- FIX: UIPopupList labels' colliders will now be properly positioned on the Z.
- FIX: Fix for UISpriteAnimationInspector not handling null strings.
- FIX: Several minor fixes for rare issues (such as playing a sound with no audio listener or main camera in the scene).

1.46:
- NEW: Added a new class (UIEventListener) that can be used to easily register event listener delegates via code without the need to create MonoBehaviours.
- NEW: Added a UIPopupList class that can be used to create drop-down lists and menus.
- NEW: Added the Popup List and Popup Menu templates to the Widget Wizard.
- NEW: UISlider can now move in increments by specifying the desired Number of Steps.
- NEW: Tutorial 11 showing how to use UIPopupLists.

1.45:
- NEW: Text labels will center or right-align their text if such pivot was used.
- NEW: Added an inspector class for the UIImageButton.
- NEW: UIGrid now has the ability to skip deactivated game objects.
- NEW: Font sprite is now imported when the font's data is imported, and will now be automatically selected from the atlas on import.
- FIX: Making widgets pixel-perfect will now make them look crisp even if their dimensions are not even (ex: 17x17 instead of 18x18).
- FIX: Component Selector will now only show actual prefabs as recommended selections. Prefab instances aren't.
- FIX: BMFontReader was not parsing lines quite right...

1.44:
- NEW: UIGrid can now automatically sort its children by name before positioning them.
- NEW: Added momentum and drag to UIDragCamera.
- NEW: Added the Image Button template to the Widget Tool.
- FIX: SpringPosition will now disable itself properly.
- FIX: UIImageButton will now make itself pixel-perfect after switching the sprites.
- FIX: UICamera will now always set the 'lastCamera' to be the camera that received the pressed event while the touch is held.
- FIX: UIDragObject will now drag tilted objects (windows) with a more expected result.

1.43:
- NEW: Added the Input template to the Widget Tool.
- NEW: UIButtonMessage will now pass the button's game object as an optional parameter.
- NEW: Tweener will now pass itself as a parameter to the callWhenFinished function.
- NEW: Tweener now has an 'eventReceiver' parameter you can set for the 'callWhenFinished' function.
- FIX: Tweener will no longer disable itself if one of OnFinished SendMessage callbacks reset it.
- FIX: Updated all tutorials to use 1.42+ functionality.
- FIX: Slider will now correctly mark its foreground widget as having changed on value change.

1.42:
- NEW: Added a new tool: Widget Creation Wizard. It replaces all "Add" functions in NGUI menu.
- NEW: Added new templates to the Widget Wizard: Button, Checkbox, Progress Bar, Slider.
- NEW: When adding widgets via the wizard, widget depth is now chosen automatically so that each new widget appears on top.
- NEW: AddWidget<> functionality is now exposed to runtime scripts (found in NGUITools).
- FIX: Widget colliders of widgets layed on top of each other are now offset by wiget's depth.
- FIX: Several minor bug fixes.

1.41:
- NEW: Added a new tool: Camera Tool. It can be used to get a bird's eye view of your cameras and determine what draws the selected object.
- NEW: Added a new tool: Create New UI. You can use it to create an entire UI hierarchy for 2D or 3D layouts with one click of a button.
- NEW: Added a new script: UIRoot. It can be used to scale the root of your UI by 2/ScreenHeight (the opposite of UIOrthoCamera).
- NEW: The NGUI menu has been enhanced. When adding widgets, it will intelligently determine where to add them best.
- NEW: Sliced sprites now have an option to not draw the center, in case you only want the border.
- FIX: Scaling sliced sprites and tiled sprites will now correctly update them again.
- FIX: Changing the depth of the widgets will now correctly update them again.
- FIX: The unnecessary color parameter specified on the material has been removed from the shaders.

1.40:
- NEW: Major performance improvements. The way the geometry was being created has been completely redone.
- NEW: With the new system, moving, rotating and scaling panels no longer causes widgets they're responsible for to be rebuilt.
- NEW: Panel clipping will now actually clip widgets, eliminating them from the draw buffers until they move back into view.
- NEW: Matrix parameter has been eliminated from the clip shaders as it's no longer needed with the new system.
- FIX: Work-around for a rare obscure issue caused by a bug in Unity related to instantiating widgets from prefabs (Case 439372).
- FIX: It's no longer possible to edit widgets directly on prefabs. Bring them into the scene first.
- FIX: Panel tool will now update itself on object selection.

1.33:
- NEW: UICheckbox now has a configurable function to call.
- NEW: UICheckbox now has an animation parameter it can trigger when checked/unchecked.
- NEW: You can now play remote animations via UIButtonPlayAnimations.
- NEW: Tweener now sends out notifications when it finishes.
- NEW: Tweener now has a 'group' parameter that can be used to only enable/disable only certain tweens on the same object.
- NEW: UIButtonTween has been changed to use more descriptive properties. Check your UIButtonTweens and update their properties after upgrading.
- NEW: Examples 1, 5 and 6 have been adjusted to use the new features.
- FIX: Scrolling speed should now be consistent even at low framerates.
- FIX: Shader fixes.

1.32:
- NEW: Added a 'thumb' parameter to the UISlider.
- NEW: Added UIForwardEvents script that can be used to forward events from one object to another.
- NEW: Added the ability to enable and disable target game objects via UIButtonTween.
- FIX: Input fields now support IME.

1.31:
- NEW: Added a panel tool (NGUI menu -> Panel Tool) to aid with multi-panel development.
- FIX: Variety of tweaks and minor enhancements, mainly related to examples.
- FIX: UIDragObject had a rare bug with how items were springing back into place.

1.30:
- NEW: UIPanels can now specify a clipping area (everything outside this area will not be visible).
- NEW: UIFilledSprite, best used for progress bars, sliders, etc (thanks nsxdavid).
- NEW: UISpriteAnimation for some simple sprite animation (attach to a sprite).
- NEW: UIAnchor can now specify depth offset to be used with perspective cameras.
- NEW: UIDragObject can now restrict dragging of objects to be within the panel's clipping bounds.
- NEW: UICheckbox now has an "option" field that lets you create option button groups (Tutorial 11).
- NEW: Example 7 showing how to use the clipping feature.
- NEW: Example 0 (Anchor) has been redone.
- NEW: Most tutorials and examples now explain what they do inside them.
- NEW: Added a variety of new interaction scripts replacing State scripts (UIButton series for example).
- NEW: Added a Drag Effect parameter to UIDragObject with options to add momentum and spring effects.
- FIX: UICamera.lastCamera was not pointing to the correct camera with multi-camera setups (thanks LKIM).
- FIX: UIAnchor now positions objects in the center of the ortho camera rather than at depth of 0.
- FIX: Various usability improvements.
- OLD: 'State' series of scripts have all been deprecated.

1.28:
- NEW: Added a simple tweener and a set of tweening scripts (position, rotation, scale, and color).
- FIX: Several fixes for rare non-critical issues.
- FIX: Flash export bug work-arounds.

1.27:
- FIX: UISlider should now work properly when centered again.
- FIX: UI should now work in Flash after LoadLevel (added some work-arounds for current bugs in the flash export).
- FIX: Sliced sprites should now look properly in Flash again (added another work-around for another bug in the Flash export).

1.26:
- NEW: Added support for trimmed sprites (and fonts) exported via TexturePacker.
- NEW: UISlider now has horizontal and vertical styles.
- NEW: Selected widgets now have their gizmos colored green.
- FIX: UISlider now uses the collider's bounds instead of the target's bounds.
- FIX: Sliced sprite will now behave better when scaled with all pivot points, not just top-left.

1.25:
- NEW: Added a UIGrid script that can be used to easily arrange icons into a grid.
- NEW: UIFont can now specify a UIAtlas/sprite combo instead of explicitly defining the material and pixel rect.

1.24
- NEW: Added character and line spacing parameters to UIFont.
- NEW: Sprites will now be sorted alphabetically, both on import and in the drop-down menu.
- NEW: NGUI menu Add* functions now automatically choose last used font and UI atlases and resize the new elements.
- FIX: UICamera will now be able to handle both mouse and touch-based input on non-mobile devices.
- FIX: 'Add Collider' menu option got semi-broken in 1.23.
- FIX: Changing the font will now correctly update the visible text while in the editor.
- Work-around for a bug in 3.5b6 Flash export.

1.23
- NEW: Added a pivot property to the widget class, replacing the old 'centered' flag.

1.22
- NEW: Example 6: Draggable Window
- FIX: UISlider will now function properly for arbitrarily scaled objects.

1.21
- FIX: Gizmos are now rotated properly, matching the widget's rotation.
- FIX: Labels now have gizmos properly scaled to envelop their entire content.

1.20
- NEW: Added the ability to generate normals and tangents for all widgets via a flag on UIPanel.
- NEW: Added a UITexture class that can be used to draw a texture without having to create an atlas.
- NEW: Example 5: Lights and Refraction.
- Moved all atlases into the Examples folder.

1.12
- FIX: Unicode fonts should now get imported correctly.

1.11
- NEW: Added a new example (4) - Chat Window.

1.10
- NEW: Added support for Unity 3.5 and its "export to Flash" feature.

1.09
- NEW: Added password fields (specified on the label)
- FIX: Working directly with atlas and font prefabs will now save their data correctly
- NEW: Showing gizmos is now an option specified on the panel
- NEW: Sprite inner rects will now be preserved on re-import
- FIX: Disabled widgets should no longer remain visible in play mode
- NEW: UICamera.lastHit will always contain the last RaycastHit made prior to sending OnClick, OnHover, and other events.

1.08
- NEW: Added support for multi-touch
