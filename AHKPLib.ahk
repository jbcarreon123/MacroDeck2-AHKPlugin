#Include C:\\Users\\jbcarreon123\\AppData\\Roaming\\Macro Deck\\plugins\\jbcarreon123.AHKPlugin\\AHKPLib\\WebSocket.ahk
val := ""
global ws

class AHKPLib
{
	__New()
	{	
		ws := new WSC("ws://localhost:8192/")
		Sleep 2500
	}

	__Destroy()
	{
		ws.Disconnect()
	}

	GetVar(Value) {
		global
		ws.Send("{'command': 'getvar', 'value': '" . Value . "'}")
		Sleep 1000
		Return val
	}

	SetVar(Value, VarType, VarValue) {
		global
		ws.Send("{'command': 'setvar', 'value': '" . Value . "', 'vartype': '" . VarType . "', 'varvalue': '" . VarValue . "'}")
		Sleep 1000
		Return val
	}

	Notify(Title, Value, ShowBalloonTip) {
		global
		ws.Send("{'command': 'notify', 'value': '" . Value . "', 'title': '" . title . "', 'boolean': '" . showballoontip . "'}")
		Sleep 1000
		Return val
	}

	Log(Value, LogType) {
		global
		ws.Send("{'command': 'log', 'value': '" . Value . "', 'vartype': '" . LogType . "'}")
		Sleep 1000
		Return val
	}

	MacroDeckVersion() {
		global
		ws.Send("{'command': 'mdver'}")
		Sleep 1000
		Return val
	}
}

class WSC extends WebSocket
{
	OnMessage(Event)
	{
		global
		val := Event.data
	}
	
	OnClose(Event)
	{
		this.Disconnect()
	}
	
	OnError(Event)
	{
		throw "Websocket Error"
	}
}