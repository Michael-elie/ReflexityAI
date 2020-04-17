﻿using System;
using Plugins.xNodeUtilityAi.MainNodes;
using Plugins.xNodeUtilityAi.MemoryNodes;
using Plugins.xNodeUtilityAi.MiddleNodes;
using Plugins.xNodeUtilityAi.PatternNodes;
using XNode;
using XNodeEditor;

namespace Plugins.xNodeUtilityAi.Framework.Editor {
    [CustomNodeGraphEditor(typeof(AIBrainGraph))]
    public class AIBrainGraphEditor : NodeGraphEditor {

        public override int GetNodeMenuOrder(Type type) {
            // Main Nodes
            if (type == typeof(OptionNode) || type == typeof(UtilityNode) || type == typeof(ConverterNode)) {
                return 1;
            }
            // Memory Nodes
            if (type == typeof(MemoryCheckNode) || type == typeof(MemoryClearNode) || type == typeof(MemoryLoadNode) || 
                type == typeof(MemorySaveNode)) {
                return 5;
            }
            // Pattern Nodes
            if (type == typeof(InCooldownNode) || type == typeof(SaveHistoricNode)) {
                return 6;
            }
            // Other Nodes
            if (type.IsSubclassOf(typeof(MiddleNode))) {
                return 4;
            }
            if (type.IsSubclassOf(typeof(DataNode))) {
                return 2;
            }
            if (type.IsSubclassOf(typeof(ActionNode))) {
                return 3;
            }
            return 0;
        }

        public override string GetNodeMenuName(Type type) {
            // Main Nodes
            if (type == typeof(OptionNode) || type == typeof(UtilityNode) || type == typeof(ConverterNode)) {
                return "MainNodes/" + NodeEditorUtilities.NodeDefaultName(type);
            }
            // Memory Nodes
            if (type == typeof(MemoryCheckNode) || type == typeof(MemoryClearNode) || type == typeof(MemoryLoadNode) || 
                type == typeof(MemorySaveNode)) {
                return "MemoryNodes/"  + NodeEditorUtilities.NodeDefaultName(type);
            }
            // Pattern Nodes
            if (type == typeof(InCooldownNode) || type == typeof(SaveHistoricNode)) {
                return "PatternNodes/"  + NodeEditorUtilities.NodeDefaultName(type);
            }
            // Other Nodes
            if (type.IsSubclassOf(typeof(MiddleNode))) {
                return "MiddleNodes/" + NodeEditorUtilities.NodeDefaultName(type);
            }
            if (type.IsSubclassOf(typeof(DataNode))) {
                return "DataNodes/" + NodeEditorUtilities.NodeDefaultName(type);
            }
            if (type.IsSubclassOf(typeof(ActionNode))) {
                return "ActionNodes/" + NodeEditorUtilities.NodeDefaultName(type);
            }
            return null;
        }

        public override string GetPortTooltip(NodePort port) {
            try {
                Type portType = port.ValueType;
                return portType.PrettyName();
            } catch (Exception) {
                return "Unable to recover port value";
            }
        }

    }
}