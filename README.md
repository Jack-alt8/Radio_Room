# Radio_Room

## About:
Radio_Room is an interactive World War 2 text-based web game demo. Help  Private Ben get through the battlefield to safety. Choose between two responses for every section of dialogue he sends to you through the radio, which is displayed on the screen. The weather is displayed in the upper left corner for context of what Private Ben’s situation is like… wherever he is. Because the game is a demo there are only two rooms. You can save your progress, by pressing the “save” button and then load your progress by pressing "load". Refresh the page to play again and try something different! 

### Features:

* Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program. When the you save your progress, your responses are put into a list and writted to the txt file.

* Make your application asynchronous. All the functionality works asychronously (data retrieval and saving and loading progress).

* Write information/data to a text file. The player’s choices will be logged and written to a text file for the player to save his progress and be able to load it again and continue playing.


#### How to Run:
1. Git pull the repository.

2. Make sure to put the api key in to the file Radio_Room.UI/Components/Actions/WeatherCheck.razor on the "string url" on line 147 after "appid=" (email me for the key if you don't have it already at jackc.baylor@gmail.com).

3. In the file, run "dotnet ef database update" (to download the database) in the vs console. Make sure you have Microsoft.EntityFrameworkCore.Tools downloaded for this command to work "dotnet tool install --global dotnet-ef". 

4. Finally, build the project and enjoy!

##### Extra:
1. Make sure to run this on Edge. Chrome will not allow a selfside certificate.

