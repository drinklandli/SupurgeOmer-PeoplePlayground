using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

namespace Mod
{
    public class Mod
    {
        public static void Main()
        {
            ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Hammer"),
                    NameOverride = "Fis Fis Supurge",
                    DescriptionOverride = "Omer'in kutsal supurgesi ama fis fis bir supurge",
                    CategoryOverride = ModAPI.FindCategory("Melee"),
                    ThumbnailOverride = ModAPI.LoadSprite("fisfissupurge.png"),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("fisfissupurge.png");
                                                    Instance.FixColliders();
                    }
                }
            );
        }
    }
}
