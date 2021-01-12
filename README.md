# BasketBall VR
Basketball VR is my attempt to create a basketball -simulation , while learning how to develop in a 3D environment, and the usage of XR- dev toolkits.

This app is designed to allow the feeling of casually shooting hoops and listening to music, as either someone locked in over the recent COVID crisis,
or someone unable to properly play due to medical reasons.

## Download exe & content here : ![Link](https://www.starshiplad.com/bball.apk) 

Please be aware, desktop browsers open this .apk file in text format.

Installation instructions can be found here (Link live as of 22/11/2020) : ![Link](https://oneirosvr.com/how-to-sideload-apps-on-oculus-quest-oculus-go/)

Links in full:
https://www.starshiplad.com/bball.apk
https://oneirosvr.com/how-to-sideload-apps-on-oculus-quest-oculus-go/


## Latest  Build

0.1a - 22/11/2020 - Initial File Dump

## Latest Update
```

0.2a (Initial File Dump) - 10/01/2021

Scene -> PlayerCharacter ->

Add 'RunAnimation' to 'PlayerCharacter'  so running animation can be run in between defend animation

Scene->PlayerCheacter -> MoveTowards.cs->

Modify 'PlayerMoveTowards' so Inbetween conditions to activate a 'gaurd' animation, 'PlayerCharacter' models perform the 'RunAnimation'
	
Basketball -> XRDirectInteractor -> 

Add 'OnSelectEnter' and 'OnSelectExit' function calls to new script 'BasketballLetGo' to mimic dribbling
		
Basketball -> BasketBallLetGo.cs ->
	
Add script 'Basketball Let Go' This has functions to performgrabbing a bounced ball and throwing a held ball to handle dribbling.
		
Scene->

Lower Lighting intensity to increase aesthetic
	
Add new house models to increase immersion.
		
Add Empty 'XRInteractionManger' to meet new XR reqirements.
		
Court -> Court Collider ->

Add Collider to basketball court so basketball can interact with basketball court for dribbling

Add Script 'Moveplayeroncollision.cs' to Court collidor so palyer mvoes foward on basketball collision to simulate dribbling
	
Modify script 'PlayerMoveTowards.cs' to have public variables'grabbed' and 'letGo', both edited by Basketball.BasketballLetgo.cs.
		
Modify Ball only bounces if bounced = false & let go true. This prevents Player moving without throwing ball. 

```

```
## Next Update

0.2a (3-D Model update) Week ending 6/12/2020
 -> Update 3D models in-game
 -> Simple optimization steps
 -> Optimize basketball throwing physics

```

```
## Next Build

*Title:* First Release
*Summary:* A simple MVP basketball sim, with satisfying dribbling, shooting and point scoring.
*Release date:* End of Feb 2021

```

## View Of Latest Update:

![Latest](Latest.png)

## Playing Basketball VR

Your right hand has a 'catcher' line that you can grab the basketball with at any distance.Use the right controller trigger to activate this and grab the basketball.

Both hands have grab functions. Simply touch the ball with a hand and press the side-trigger on the controller touching the basketball. Let go of that trigger to release the ball.

Hitting the speaker with a ball will change the current song.

Press the primary button on the right controller to remove the 'Catcher Line'. Press it again to return it.

Dropping the ball near you will move you in the direction you are looking.

Opposition players will move quite close to you so watch out for accidental jump-scares! 


## Features(Planned In Brackets)

* Sound effects when the basketball interacts with objects (Net, backboard ect. ect.).

* Animated opposition characters.

* Music-playing speakers.

* Ball safety-measures ( The ball will always be grab-able ).

* Smooth FPS on a mobile oculus quest device. 

* ( Opposition players can steal ball and take shots. )

* ( Score system. )

* ( Title Page and proper UI. )

*  Dribbling to move character.


## Skill developing

I plan on this project improving my skills in the following:

> Customer interaction and feedback-actioning (I have asked several of my associates more knowledgeable in art direction, animation or basketball for regular feedback.)

> 3D model creation and character animation (Blender , FBX ).

> VR/ XR development toolkit knowledge.

>Social Media management and content creation.

!Developed by Starshiplad ![Twitter](https://twitter.com/StarshipladDevp) 

![Developed by Starshipladdev](LogoFull.png)
