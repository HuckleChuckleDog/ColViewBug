# ColViewBug
Error with swipe view tap gesture 

The error here is with some android phones "such as Samsung note 10+ & samsung galaxy," if you have a control used for the swipe view content where there is a tap gesture recognizer 
attached to the content view, then when the tap to an item is pressed, this will invoke the Swipe Started, Swipe Changing & Swipe Ended events -- This isn't an issue on all
android devices nor is this an issue for iOS.

However, if you remove the tap gesture recognizer from the control used as the swipe view item content and attach the gesture recognizer to the swipe view like below
                        <SwipeView.GestureRecognizers>
                            <TapGestureRecognizer Command=""                            />
                        </SwipeView.GestureRecognizers>
                        
Then this will work for the problematic android devices such as Note 10+ however it won't work correctly for iOS e.g. if pressing on the swipe button in iOS this will trigger bother
swipe button action as well as the action assigned to the tap gesture recognizer.

One more problem which there is a work around for -- this problem only exists with Android "once again only some devices" is that if you set up the Swipe View with a custom
swipe items e.g. Buttons instead of <SwipeItem> then the buttons may not invoke action correctly e.g. on first tap.
