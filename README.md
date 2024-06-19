# Day Night System
This system is the beginning of night day cycle system. It should give you enough to extend it to your game's needs. It includes a time manager that cycles through a day, a custom sky shader graph where you can set the day and night.
The time manager blends the two different skyboxes together during sunrise and sunset.

![Unity_w4fpg7sDlJ](https://github.com/NachoCheese017/day-night-system/assets/23500697/61630a78-04fd-43ba-9edb-59a4e8e0e4c5)


## Skybox Shader
Because the skybox is a custom shader, there's a lot you can customize: 

![image](https://github.com/NachoCheese017/day-night-system/assets/23500697/2cb1d924-9a45-4a59-9fe3-920c3231f61d)

## Time Manager
The time manager cycles through the day and blends the two different skyboxes together during sunrise and sunset.

> [!WARNING] 
> Currently the moon light source isn't fully supported yet. It is referenced in the object but it doesn't work yet. This is a WIP.

- You can use the time manager to update the UI display for the time.
- Different intensities for the sun and moon.
- Adjust the curve of the light intensity.

![Screenshot 2024-06-19 083658](https://github.com/NachoCheese017/day-night-system/assets/23500697/d871c757-7526-4043-bbc7-9173ab54b1cf)

### Time settings
The time manager uses the time settings scriptable object for it's settings. In here you can specify what hours you want the sunrise and sunset. 

The start hour property is the time the game starts when you start it. 


![image](https://github.com/NachoCheese017/day-night-system/assets/23500697/7d567b33-3dd5-4875-8444-b10057f8d04a)


### Controls
To speed up time in runtime you can use the ``space`` key. to slow down time you can use the ``shift`` key. 

> [!NOTE]
> It is possible to expand this functionality to be part of the game. If you allow the player to control the time, this is a great start.
