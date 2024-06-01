﻿using DanhengPlugin.BasePlugin.TutorialData;
using EggLink.DanhengServer.Plugin.Constructor;
using EggLink.DanhengServer.Plugin.Event;
using EggLink.DanhengServer.Util;

namespace DanhengPlugin.BasePlugin
{
    public class DanhengBasePlugin : IPlugin
    {
        Logger logger = new("BasePlugin");
        public void OnLoad()
        {
            logger.Info("BasePlugin loaded");

            PluginEvent.OnPlayerHeartBeat += new OnPlayerHeartBeat().PlayerHeartBeat;
        }

        public void OnUnload()
        {
            logger.Info("BasePlugin unloaded");
        }
    }
}
