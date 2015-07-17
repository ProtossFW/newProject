using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class EventManage {
	static Dictionary<string,Action> masageMap =new Dictionary<string,Action> ();
	static Dictionary<string,Action<string>> masageMap_string =new Dictionary<string,Action<string>> ();
	public static void AddEvent (string eventName,Action action) {
		if (!masageMap.ContainsKey (eventName))
			masageMap.Add (eventName, action);
	}

	public static void DoEvent (string eventName) {
		if (masageMap.ContainsKey (eventName))
			masageMap [eventName] ();
	}

	public static void AddEventWithStr (string eventName,Action<string> action) {
		if (!masageMap_string.ContainsKey (eventName))
			masageMap_string.Add (eventName,action);
	}

	public static void DoEventWithStr (string eventName,string str) {
		if (masageMap_string.ContainsKey (eventName))
			masageMap_string [eventName] (str);
	}
}
