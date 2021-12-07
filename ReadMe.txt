============Updates===========

For adding door on Main Scene

	Teleport Ability:
	There is DoorTeleport prefab in Prefab file. You can add this door to Main scene even you dont
	need to add extra script(one of the fixed scripts). If you sclick door object in the hierarchy
	and look inspector to find Teleport (Script) component you will see Tp area. If you write scene
	naem with case sensetive here it will automatically add teleport scene.

	Add image to Door in Main:
	Without open prefab of doorTeleport you can add "Inside" gameobject. You can find "Inside" under
	DoorTeleport hierarchy. 

For Enviroment Scenes:

	Add Return Main Scene Door:
	In new update ther is "DoorMain Variant"(aka DoorMain) prefab in Prefab file. Also you must add 
	DoorPoint you can also find it at Prefab file. Make DoorMain position x=0,y=-300,z=200. Make
	DoorPoint position refers where you want your DoorMain to land(Caution: THER MUST BE NOTHING ABOVE DoorPoint).
	If you add new DoorMain you will notice that under inspector "Range Within (Script)" Player and Door Landing Point
	will be empty iti is easy to solve this problem. Add youR Avatar game object to Player and add 
	your DoorPoint game object on Door Landing Point.

	Add Meditation Point: 
	(Caution: DO NOT ADD MEDITATION POINT ON MAIN SCRENE.)
	You can find MeditationPoint prefab in Prefab file. After adding MeditationPoint in your scene 
	hierarchy you MUST also add "FeedBack for Sitting" prefab in hierarchy you can also fing 
	"Feedback for Sitting" prefab in Prefab file. 
	
	Lets look at MeditationPoint inspector and find "Move Mediation Point (Script)".
	* Add "Avatar" game object to Player.
	* Add "Feedback for Sitting" game object to "Ui Text Message"
	* Add "on" (you can find it at hiearchy of "Feedback for Sitting") game object to "On Text"
	* Add "off" (you can find it at hiearchy of "Feedback for Sitting") game object to "Off Text"

	Lets look at Avatar inspector and find "Avatar Ability (Script)".
	You will find Arr variable inside it. Make Arr size equal to how much MeditationPoint you have(Without 
	first index 0. For example if you have 2 MeditationPoint Arr size should be 2).
	* Add you MeditationPoint each element in Arr (Make this process in inspector)
	(Caution: AVATAR IN MAIN SCENE 'S Arr SIZE SHOULD BE ZERO).
	
	



	
