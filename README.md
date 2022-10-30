# AutoHotkey Plugin Library for AutoHotkey 1.1
Sometimes, you need a more *special* way to communicate to the plugin itself. Introducing, the AHKPLib!   
It will default to port 8192, port change coming soon.

## Initial
```ahk
#Include AHKPLib.ahk ; makes so the script can use the library
AHKPLib := new AHKPLib() ; this will connect the library to the plugin
```

## Variable Related stuff
### ```AHKPLib.GetVar(string value)```
Parameters:   
value - the variable name   
Outputs a string with the variable value

### ```AHKPLib.SetVar(string value, string vartype, string varvalue)```
Parameters:   
value - the variable name   
vartype - the variable type. Possible values are ```String (str)```, ```Boolean (bool)```, ```Float (fl)```, and ```Integer (int)```. Case-insensitive.

### DelVar coming soon.

## Other stuff
### ```AHKPLib.Notify(string title, string value, string showballoontip)```
Parameters:   
title - the title of the notification   
value - the content of the notification   
showballoontip - if it shows a ballon tip. Possible values are ```true``` and ```false```. Case-insensitive.   
Notes:   
Notifications always says ```AutoHotkey Plugin```. You can't change it.

### ```AHKPLib.Log(string value, string vartype)```
Parameters:   
value - the content of the log   
vartype - the type of the log. Possible values are ```Info```, ```Trace```, ```Warning```, and ```Error```. Case-insensitive.   
Notes:
Like Notifications, Logs always says ```AutoHotkey Plugin```. You can't change it.

### ```AHKPLib.MacroDeckVersion()```
Outputs the version of Macro Deck. Useful if you need to know the version of Macro Deck.

## Third-party Libraries
AHKPLib uses this libraries:   
[WebSocket.ahk](https://github.com/G33kDude/WebSocket.ahk) (by Philip Taylor, also known as GeekDude or G33kDude)