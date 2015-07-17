using UnityEngine;
using System.Collections;

public class LogicManage : MonoBehaviour {
	private static LogicManage instance;
	public static LogicManage Instance {
		get {
			if(instance == null) {
				instance = new LogicManage();
			}
			return LogicManage.instance;
		}
	}

	public void Initialize () {
		ViewManage.Instance.onGMbut += OnShowGMMasage;
		ViewManage.Instance.test += OnShowTestMsg;
	}

	public void OnShowGMMasage () {
		EventManage.DoEvent ("ShowGMUI");
	}

	public void OnShowTestMsg () {
		EventManage.DoEvent ("ShowTestUI");
	}
}
