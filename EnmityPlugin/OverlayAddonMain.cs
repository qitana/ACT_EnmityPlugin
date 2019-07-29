﻿using RainbowMage.OverlayPlugin;
using System;
using System.Reflection;

namespace Tamagawa.EnmityPlugin
{
    public class OverlayAddonMain : IOverlayAddon
    {
        // OverlayPluginのリソースフォルダ
        public static string ResourcesDirectory = String.Empty;
        public static string UpdateMessage = String.Empty;

        public OverlayAddonMain()
        {
            // OverlayPlugin.Coreを期待
            Assembly asm = System.Reflection.Assembly.GetCallingAssembly();
            if (asm.Location == null || asm.Location == "")
            {
                // 場所がわからないなら自分の場所にする
                asm = Assembly.GetExecutingAssembly();
            }
            ResourcesDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(asm.Location), "resources");
        }

        static OverlayAddonMain()
        {
            // static constructor should be called only once
            //UpdateMessage = UpdateChecker.Check();
            UpdateMessage = "UpdateChecker is Disabled.";
        }

        public string Name => "Enmity";

        public string Description => "Show enmity values of current target.";

        public Type OverlayType => typeof(EnmityOverlay);

        public Type OverlayConfigType => typeof(EnmityOverlayConfig);

        public Type OverlayConfigControlType => typeof(EnmityOverlayConfigPanel);

        public IOverlay CreateOverlayInstance(IOverlayConfig config) => new EnmityOverlay((EnmityOverlayConfig)config);

        public IOverlayConfig CreateOverlayConfigInstance(string name) => new EnmityOverlayConfig(name);

        public System.Windows.Forms.Control CreateOverlayConfigControlInstance(IOverlay overlay) => new EnmityOverlayConfigPanel((EnmityOverlay)overlay);

        public void Dispose() { }
    }
}