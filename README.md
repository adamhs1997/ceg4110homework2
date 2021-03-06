# CEG 4110 Homework 2

**Adam Horvath-Smith, 10-11-2018**

_Second homework assignment for CEG 4110, Wright State University, Fall 2018._

This app, affectionately called "Clock Master", allows users to open numerous digital and analog clocks set to a time of their choosing. This app takes advantage of the Model-View-Controller design pattern to make it possible to update the time in one central settings window and have the changes apply to all open clocks. Further, thanks to the Command design pattern, it is possible to undo or redo any changes the user made to the time displayed on the clocks.

# Running this app on your phone

To run this app on your phone, simply download and load the Homework2.apk file onto your phone. _No external resources/files are needed to run the app on your device._ After downloading the apk onto your computer, connect your phone to it with a USB cable. You may have to enable file sharing on your phone to be able to access its file system on your computer. Then, simply move the apk anywhere onto your phone's storage and, from your phone's file explorer, run the apk. Follow the prompts to install the app. (You may have to allow your phone to install from untrusted sources.) Once the installer is done, open the app and enjoy!

Should you choose to be ambitious and compile this project from source, you will first need to make sure you have the Xamarin tools for Visual Studio installed. (See https://docs.microsoft.com/en-us/xamarin/cross-platform/get-started/installation/ for help doing this.) Then, simply clone the entire project onto your computer and open the solution file (Homework2.sln). You should be able to simply compile and run the application in your emulator or on your device from there. However, Xamarin is still a little touchy with the external Java libraries that are ported into this project. _If all or part of the application fails to run,_ select Build->Rebuild Solution from the toolbar in Visual Studio. This will rebuild the entire project, including the bindings for external libraries. The application should run from there.

# How to use this app

The Clock Master app is very simple. Upon opening the app, users are presented with a main menu, giving them four options as to what they can do. The first two options allow the user to add clocks to their list of open clocks. Namely, users can choose to open either a digital or analog clock. Selecting either of these options _does not_ open the clock, it simply adds it to the open clock list. A toast notification will notify users that their request was successful.

To open a clock, users will need to choose the "View Open Clocks" option from the main menu. This will display a list of all clocks the user currently has open. Selecting one of these clocks will display the time to the user in the proper format. By default, the clock will match the current time of day. However, if the user has changed the time within the app, this time will be displayed on all open clocks.

_A glance at the different clock views..._

_Analog Clock_                                                                                                 |  _Digital Clock_
:-------------------------------------------------------------------------------------------------------------:|:-------------------------:
![](https://github.com/adamhs1997/ceg4110homework2/raw/master/Screenshots/Screenshot_2018-10-11-17-06-22.png)  |  ![](https://github.com/adamhs1997/ceg4110homework2/raw/master/Screenshots/Screenshot_2018-10-11-17-06-17.png)

Going back to the main menu, users will see a fourth option that allows them to change settings in the app. Here, users can choose the hours, minutes, and seconds displayed on the clocks, as well as the month, day, and year displayed as the date. Users may only increment or decrement each of these six options one step at a time. It is _not_ possible to manually enter a new value from the device keyboard. Should the user choose to revert any changes made to the app's time, he or she may undo these from this menu as well. Changes that were undone can also be redone here.

_The settings view_

<img src="https://github.com/adamhs1997/ceg4110homework2/raw/master/Screenshots/Screenshot_2018-10-11-17-06-29.png" width="410">

There is one important thing to note about the operation of this app while the time is being adjusted. _While the settings menu is open, the clock is stopped._ This is much like the way a wristwatch operates; in order to adjust the time, one must first stop the clock. As soon as the user finalizes his or her time settings and closes the menu, the clock again begins to tick with the newly set time. This was done so that the time settings window always displays the exact time the user can expect to see on the clock after the settings are changed.

# Design and Implementation

This app was written in C# under Microsoft's Xamarin framework for the Android operating system. This was smooth overall; however, challenges with this particular platform arose when trying to import third-party libraries to create both the analog and digital clock views. In [Homework 1](https://github.com/adamhs1997/ceg4110homework1), the color picker library I chose was available as a .aar file, which was easy to import into Xamarin. I was not able to find such libraries for this project. Instead, I could only find libraries that would normally be linked in as Gradle dependencies (which is apparently far more common). The problem here is, Xamarin doesn't use Gradle. After several hours, I was able to find a Visual Studio plugin that allowed be to load in these dependencies and use the libraries I wanted. Unfortunately, this proved to be much more time-consuming than the actual implementation of the logic of the project.

As noted, both the Model-View-Controller and Command design patterns are crucial to the operation of this application. At a high level, to implement Model-View-Controller, classes were created for each the Clock Model and Clock Controller, as well as a generic Clock View interface used to program the concrete Analog Clock View and Digital Clock View. Likewise, for the Command design pattern, a generic Command interface was first created, which was later used to program each of the twelve increment and decrement options seen in the Settings View window. A Launcher View was created for the main menu of the application, which is responsible for launching other views and activities. Aside from creating new clocks, this view allowed users to access the Clocks List View (where users could view their open clocks) as well as the Settings View (where users could change time settings). A more concrete picture of the design of this application can be seen by viewing the UML class diagram attached to the final submission of this project. (The class diagram is not part of this GitHub repo.)

As mentioned previously, outside libraries were used to create my digital and analog clocks. Despite my difficulties importing their libraries into my project, these were a big part of the end result. So, of course, these developers do deserve some recognition! My analog clock was implemented using the library hosted at https://github.com/TurkiTAK/vector-analog-clock. You may note that my analog clock glitches for a moment every second as it updates. This is _not_ an issue in this library. The original analog clock is _very_ smooth; only when I update this clock manually does it glitch out. The digital clock is courtesy https://github.com/xenione/tab-digit. This library actually is a class for "tab digits", like those you would see on an old electric clock (where physical tabs would flip to the next number). This flip animation is also lost in my implementation of a digital clock, so all you see is the number changing every second. Again, this is a by-product of my manual updating of the digits from the clock model.

This project took a good deal of time and stress, but I am happy with the end result. I had more hiccups along the way than I did with [Homework 1](https://github.com/adamhs1997/ceg4110homework1), but I was eventually able to piece a final product together.

# Acknowledgments

Aside from the resources noted above, I should again iterate that this is a class project for CEG 4110 (Introduction to Software Engineering) at Wright State University. The app idea is not my own; requirements were specified in the project outline given to the class by Dr. Derek Doran. The design and implementation of this app, aside from the imported clock libraries, is completely my own.

