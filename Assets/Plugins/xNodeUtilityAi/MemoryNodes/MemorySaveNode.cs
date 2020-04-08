﻿using System;
using Plugins.xNodeUtilityAi.Framework;
using Plugins.xNodeUtilityAi.Utils.TagList;

namespace Plugins.xNodeUtilityAi.MemoryNodes {
    public class MemorySaveNode : ActionNode {

        [DropdownList(typeof(TagListHelper), nameof(TagListHelper.GetMemoryTags))] 
        public string MemoryTag;

        public override void Execute(object context, object[] parameters) {
            // if (string.IsNullOrEmpty(MemoryTag)) 
            //     throw new Exception("MemorySaveNode contain no dataTag, please select one");
            // context.SaveInMemory(MemoryTag, data);
        }

        public override object GetContext() {
            throw new NotImplementedException();
        }

        public override object[] GetParameters() {
            throw new NotImplementedException();
        }
    }

}