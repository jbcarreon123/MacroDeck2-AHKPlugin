#Include C:\\Users\\jbcarreon123\\AppData\\Roaming\\Macro Deck\\plugins\\jbcarreon123.AHKPlugin\\AHKPLib\\WebSocket.ahk
val := ""
message := false
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
		ws.Close()
	}

	GetVar(Value) {
		global
		ws.Send("{'command': 'getvar', 'value': '" . Value . "'}")
		While (message == false) {
			continue
		}
		Return val
	}

	SetVar(Value, VarType, VarValue) {
		global
		ws.Send("{'command': 'setvar', 'value': '" . Value . "', 'vartype': '" . VarType . "', 'varvalue': '" . VarValue . "'}")
		While (message == false) {
			continue
		}
		Return val
	}

	DelVar(Value) {
		global
		ws.Send("{'command': 'delvar', 'value': '" . Value . "'}")
		While (message == false) {
			continue
		}
		Return val
	}

	Notify(Title, Value, ShowBalloonTip) {
		global
		ws.Send("{'command': 'notify', 'value': '" . Value . "', 'title': '" . title . "', 'boolean': '" . showballoontip . "'}")
		While (message == false) {
			continue
		}
		Return val
	}

	Log(Value, LogType) {
		global
		ws.Send("{'command': 'log', 'value': '" . Value . "', 'vartype': '" . LogType . "'}")
		While (message == false) {
			continue
		}
		Return val
	}

	MacroDeckVersion() {
		global
		ws.Send("{'command': 'mdver'}")
		While (message == false) {
			continue
		}
		Return val
	}
}

class WSC extends WebSocket
{
	OnMessage(Event)
	{
		global
		message := true
		val := Event.data
		message := false
	}
	
	OnClose(Event)
	{
		this.Disconnect()
	}
}