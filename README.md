# AutoHotkey Plugin for Macro Deck 2
<img alt="Macro Deck 2 Community Plugin" height="64px" position="center" href="https://macrodeck.org" src="https://macrodeck.org/images/macro_deck_2_community_plugin.png"/> Macro Deck 2 Community Plugin: does NOT work in Macro Deck Server or a standalone program

***

## Run AutoHotkey script
Choose your existing AHK script file and leave it! It will now work!

## Write and Run AutoHotkey scripts
or, Write a new AHK script and leave it! AHK Plugin will run it if you pressed the action button!

### Variables [2.0.0+]
Writing scripts within Macro-Deck allows using Variables. Since AHK makes use of `{` and `}` we use double `{{` and `}}` to indicate a Variable in AWH WriteScripts (example `{{my_variable}}`).
Example:
```ahk
MsgBox, It is now {{time}} and the date is {{date}}.
```
Thanks [@Timoses](https://github.com/Timoses) for coding this feature!

### [AutoHotkey Plugin Library for AutoHotkey 1.1](https://github.com/jbcarreon123/MacroDeck2-AHKPlugin/tree/AHKPLib) [3.0.0+]
> :warning: This feature is now depectated. This will be replaced by AHKPLibv2 that uses StdOut instead of Websockets to ensure v1 and v2 compatibility.

Using the WriteScript v1.1 action now allows you to make communication to AHK Plugin to create a variable, get variables, update variables, create a notification and more.
Example:
```ahk
#Include AHKPLib.ahk
ExampleApp := new AHKPLib()
MsgBox % ExampleApp.GetVar("date")
```
Documentation is available on the link above.

## Automation
From pushing a key combination to automating PowerPoint *[RIP Office (the name)]*, AHK Plugin can do that.
Use AHK Plugin with other plugins for automated tasks in Macro Deck!

## Features
AHK Plugin has these actions:   
| **Action** | **Description** | **Status** |
| --- | --- | --- |
| **Run AHK Script** | Run a AutoHotkey script | Live |
| **Write and Run AHK Script** | Write and run a AHK Script | Live |
| **Window Spy** | AHK's built-in Window Spy | Live |
More features coming soon.

## Supports AHK version 2!
AHK Plugin supports AutoHotkey version 2 and you can interchange version 1 and 2 *[1.1.0]*.

## Notes
This is a plugin for Macro Deck 2, it does NOT function as a standalone app  
This requires AutoHotkey (AHKv2 is optional) and needs to be pointed to the folder path that AHK is on.

## Third-party Licenses
AHK Plugin uses this wonderful 3rd-party libraries:   
- [Macro Deck 2 [by SuchByte]](https://macrodeck.org/) (Apache License 2.0)   
- [Newtonsoft.Json](https://www.newtonsoft.com/json) (MIT License)
- [Fleck](https://github.com/statianzo/Fleck) (MIT License)
- [AutoHotkey](https://autohotkey.com) (GPL-2.0 License)

Icon is a merge of Macro Deck 2 and the autohotkey.com favicon.
