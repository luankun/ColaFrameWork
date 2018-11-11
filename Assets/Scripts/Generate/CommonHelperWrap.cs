﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class CommonHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("CommonHelper");
		L.RegFunction("GetText", GetText);
		L.RegFunction("AddBtnMsg", AddBtnMsg);
		L.RegFunction("RemoveBtnMsg", RemoveBtnMsg);
		L.RegFunction("InstantiateGoByID", InstantiateGoByID);
		L.RegFunction("InstantiateGoByPrefab", InstantiateGoByPrefab);
		L.RegFunction("GetGameObjectByName", GetGameObjectByName);
		L.RegFunction("GetGameObjectsByName", GetGameObjectsByName);
		L.RegFunction("FindChildByPath", FindChildByPath);
		L.RegFunction("GetResourceMgr", GetResourceMgr);
		L.RegFunction("GetModuleMgr", GetModuleMgr);
		L.RegFunction("GetUIMgr", GetUIMgr);
		L.RegFunction("SetImageSpriteFromAtlas", SetImageSpriteFromAtlas);
		L.RegFunction("SetRawImage", SetRawImage);
		L.RegFunction("SetImageGray", SetImageGray);
		L.RegFunction("SetRawImageGray", SetRawImageGray);
		L.RegFunction("GetDeviceInfo", GetDeviceInfo);
		L.RegFunction("GetBatteryLevel", GetBatteryLevel);
		L.RegFunction("GetBatteryStatus", GetBatteryStatus);
		L.RegFunction("GetNetworkStatus", GetNetworkStatus);
		L.RegFunction("CheckFuncOpen", CheckFuncOpen);
		L.RegFunction("WorldToUIPoint", WorldToUIPoint);
		L.RegFunction("ActivedChildCount", ActivedChildCount);
		L.RegFunction("GetAssetPath", GetAssetPath);
		L.RegFunction("IsArrayContainString", IsArrayContainString);
		L.RegFunction("GetHostIp", GetHostIp);
		L.RegFunction("ChildCount", ChildCount);
		L.RegFunction("GetChild", GetChild);
		L.RegFunction("GetTerrainHeight", GetTerrainHeight);
		L.RegFunction("GetNavMeshHeight", GetNavMeshHeight);
		L.RegFunction("StartCoroutine", StartCoroutine);
		L.RegFunction("StopCoroutine", StopCoroutine);
		L.RegFunction("StopAllCoroutines", StopAllCoroutines);
		L.RegFunction("TextTyperEffect", TextTyperEffect);
		L.RegFunction("GetChineseNumber", GetChineseNumber);
		L.RegFunction("CheckLocalFileExist", CheckLocalFileExist);
		L.RegFunction("ResourcesClearAndGC", ResourcesClearAndGC);
		L.RegFunction("SliceTextureToSprite", SliceTextureToSprite);
		L.RegVar("osDir", get_osDir, set_osDir);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetText(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			string o = CommonHelper.GetText(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddBtnMsg(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Action<UnityEngine.GameObject> arg1 = (System.Action<UnityEngine.GameObject>)ToLua.CheckDelegate<System.Action<UnityEngine.GameObject>>(L, 2);
			CommonHelper.AddBtnMsg(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveBtnMsg(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			System.Action<UnityEngine.GameObject> arg1 = (System.Action<UnityEngine.GameObject>)ToLua.CheckDelegate<System.Action<UnityEngine.GameObject>>(L, 2);
			CommonHelper.RemoveBtnMsg(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InstantiateGoByID(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.GameObject arg1 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			UnityEngine.GameObject o = CommonHelper.InstantiateGoByID(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InstantiateGoByPrefab(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			UnityEngine.GameObject arg1 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
			UnityEngine.GameObject o = CommonHelper.InstantiateGoByPrefab(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObjectByName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			string arg1 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = CommonHelper.GetGameObjectByName(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetGameObjectsByName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			string arg1 = ToLua.CheckString(L, 2);
			System.Collections.Generic.List<UnityEngine.GameObject> o = CommonHelper.GetGameObjectsByName(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int FindChildByPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			string arg1 = ToLua.CheckString(L, 2);
			UnityEngine.GameObject o = CommonHelper.FindChildByPath(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResourceMgr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			ResourceMgr o = CommonHelper.GetResourceMgr();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetModuleMgr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			ModuleMgr o = CommonHelper.GetModuleMgr();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUIMgr(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UIMgr o = CommonHelper.GetUIMgr();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetImageSpriteFromAtlas(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			UnityEngine.UI.Image arg1 = (UnityEngine.UI.Image)ToLua.CheckObject<UnityEngine.UI.Image>(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			bool arg3 = LuaDLL.luaL_checkboolean(L, 4);
			CommonHelper.SetImageSpriteFromAtlas(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRawImage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.UI.RawImage arg0 = (UnityEngine.UI.RawImage)ToLua.CheckObject<UnityEngine.UI.RawImage>(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			bool arg2 = LuaDLL.luaL_checkboolean(L, 3);
			CommonHelper.SetRawImage(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetImageGray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.Image arg0 = (UnityEngine.UI.Image)ToLua.CheckObject<UnityEngine.UI.Image>(L, 1);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			CommonHelper.SetImageGray(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRawImageGray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.UI.RawImage arg0 = (UnityEngine.UI.RawImage)ToLua.CheckObject<UnityEngine.UI.RawImage>(L, 1);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			CommonHelper.SetRawImageGray(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDeviceInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = CommonHelper.GetDeviceInfo();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBatteryLevel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			float o = CommonHelper.GetBatteryLevel();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBatteryStatus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.BatteryStatus o = CommonHelper.GetBatteryStatus();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNetworkStatus(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.NetworkReachability o = CommonHelper.GetNetworkStatus();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckFuncOpen(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
			CheckFuncResult o = CommonHelper.CheckFuncOpen(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WorldToUIPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 1, typeof(UnityEngine.Camera));
			UnityEngine.Canvas arg1 = (UnityEngine.Canvas)ToLua.CheckObject(L, 2, typeof(UnityEngine.Canvas));
			UnityEngine.Vector3 arg2 = ToLua.ToVector3(L, 3);
			UnityEngine.Vector2 o = CommonHelper.WorldToUIPoint(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ActivedChildCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckObject<UnityEngine.Transform>(L, 1);
			int o = CommonHelper.ActivedChildCount(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAssetPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = CommonHelper.GetAssetPath();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsArrayContainString(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			string arg0 = ToLua.CheckString(L, 1);
			string[] arg1 = ToLua.CheckParamsString(L, 2, count - 1);
			bool o = CommonHelper.IsArrayContainString(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHostIp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = CommonHelper.GetHostIp();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChildCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			int o = CommonHelper.ChildCount(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			UnityEngine.GameObject o = CommonHelper.GetChild(arg0, arg1);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTerrainHeight(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				float o = CommonHelper.GetTerrainHeight(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float o = CommonHelper.GetTerrainHeight(arg0, arg1);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: CommonHelper.GetTerrainHeight");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetNavMeshHeight(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
			float o = CommonHelper.GetNavMeshHeight(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartCoroutine(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				CommonHelper.StartCoroutine(arg0);
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes<System.Collections.IEnumerator>(L, 1))
			{
				System.Collections.IEnumerator arg0 = (System.Collections.IEnumerator)ToLua.ToObject(L, 1);
				CommonHelper.StartCoroutine(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: CommonHelper.StartCoroutine");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopCoroutine(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			CommonHelper.StopCoroutine(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopAllCoroutines(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			CommonHelper.StopAllCoroutines();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TextTyperEffect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			UnityEngine.UI.Text arg0 = (UnityEngine.UI.Text)ToLua.CheckObject<UnityEngine.UI.Text>(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 4);
			CommonHelper.TextTyperEffect(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChineseNumber(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			string o = CommonHelper.GetChineseNumber(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CheckLocalFileExist(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = CommonHelper.CheckLocalFileExist(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResourcesClearAndGC(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			CommonHelper.ResourcesClearAndGC();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SliceTextureToSprite(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)ToLua.CheckObject(L, 1, typeof(UnityEngine.Texture2D));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 5);
			UnityEngine.Sprite o = CommonHelper.SliceTextureToSprite(arg0, arg1, arg2, arg3, arg4);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_osDir(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, CommonHelper.osDir);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_osDir(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			CommonHelper.osDir = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

