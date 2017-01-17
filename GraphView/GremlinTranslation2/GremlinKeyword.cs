﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphView
{
    public class GremlinKeyword
    {
        public const string Label = "label";
        public const string EdgeID = "_ID";
        public const string EdgeSourceV = "_source";
        public const string EdgeSinkV = "_sink";
        public const string EdgeOtherV = "_other";
        public const string NodeID = "id";
        public const string EdgeAdj = "_edge";
        public const string ReverseEdgeAdj = "_reverse_edge";
        public const string TableValue = "_t";
        public const string Path = "_path";
        public const string DefaultProject = "_result";
        public const string ScalarValue = "_value";
        public const string Star = "*";

        public static class func
        {
            public const string Coalesce = "Coalesce";
            public const string Constant = "Constant";
            public const string OutE = "OutE";
            public const string InE = "InE";
            public const string BothE = "BothE";
            public const string FlatMap = "FlatMap";
            public const string Key = "Key";
            public const string Local = "Local";
            public const string OutV = "OutV";
            public const string InV = "InV";
            public const string BothV = "BothV";
            public const string Optional = "Optional";
            public const string Properties = "Properties";
            public const string Repeat = "Repeat";
            public const string Value = "Value";
            public const string Values = "Values";
            public const string Unfold = "Unfold";
            public const string Union = "Union";
            public const string Project = "Project";
            public const string AddV = "AddV";
            public const string AddE = "AddE";
            public const string SideEffect = "SideEffect";
            public const string Dedup = "Dedup";
            public const string Fold = "fold";
            public const string Count = "count";
            public const string DropNode = "DropNode";
            public const string DropEdge = "DropEdge";
            public const string DropProperties = "DropProperties";
            public const string UpdateNodeProperties = "UpdateNodeProperties";
            public const string UpdateEdgeProperties = "UpdateEdgeProperties";
            public const string Path = "Path";
            public const string Inject = "Inject";
            public const string Tree = "Tree";
            public const string OtherV = "OtherV";
            public const string Expand = "Expand";
            public const string Map = "Map";
            public const string Compose1 = "Compose1";
            public const string Group = "Group";
        }
        public enum Pop
        {
            Default,
            first,
            last
        }

        public enum Column
        {
            //The values and keys enums are from Column which is used to select "columns" from a Map, Map.Entry, or Path. 
            keys,
            values
        }

        public enum Scope
        {
            local,
            global
        }
        public enum Order
        {
            Shuffle,
            Desr,
            Incr
        }

        public static readonly Dictionary<string, string> GremlinStepToGraphTraversalDict = new Dictionary
            <string, string>()
            {
                {"as", "As"},
                {"addV", "AddV"},
                {"addE", "AddE"},
                {"and", "And"},
                {"barrier", "Barrier"},
                {"both", "Both"},
                {"by", "By"},
                {"cap", "Cap"},
                {"count", "Count"},
                {"constant", "Constant"},
                {"coalesce", "Coalesce"},
                {"drop", "Drop"},
                {"dedup", "Dedup"},
                {"fold", "Fold"},
                {"from", "From"},
                {"flatMap", "FlatMap"},
                {"has", "Has"},
                {"hasLabel", "HasLabel"},
                {"is", "Is"},
                {"inject", "Inject"},
                {"id", "Id"},
                {"identity", "Identity"},
                {"inV", "InV"},
                {"in", "In"},
                {"inE", "InE"},
                {"key", "Key"},
                {"label", "Label"},
                {"local", "Local"},
                {"map", "Map"},
                {"not", "Not"},
                {"optional", "Optional"},
                {"otherV", "OtherV"},
                {"out", "Out"},
                {"outE", "OutE"},
                {"outV", "OutV"},
                {"property", "Property"},
                {"properties", "Properties"},
                {"project", "Project"},
                {"sideEffect", "SideEffect"},
                {"select", "Select"},
                {"store", "Store"},
                {"repeat", "Repeat"},
                {"until", "Until"},
                {"emit", "Emit"},
                {"range", "Range"},
                {"to", "To"},
                {"tree", "Tree"},
                {"unfold", "Unfold"},
                {"union", "Union"},
                {"values", "Values"},
                {"V", "V"},
                {"where", "Where"},

                {"next", "Next"},
                {"toList", "ToList"}
            };

        public static readonly Dictionary<string, string> GremlinMainStepToGraphTraversalDict = new Dictionary
            <string, string>()
            {
                {"__.", "GraphTraversal2.__()."},
                {"g.", "graph.g()."}

            };

        public static readonly Dictionary<string, string> GremlinPredicateToGraphTraversalDict = new Dictionary
            <string, string>()
            {
                {"eq", "Predicate.eq"},
                {"neq", "Predicate.neq"},
                {"lt", "Predicate.lt"},
                {"lte", "Predicate.lte"},
                {"gt", "Predicate.gt"},
                {"gte", "Predicate.gte"},
                {"inside", "Predicate.inside"},
                {"outside", "Predicate.outside"},
                {"between", "Predicate.between"},
                {"within", "Predicate.within"},
                {"without", "Predicate.without"}
            };

        public static readonly Dictionary<string, string> GremlinKeywordToGraphTraversalDict = new Dictionary<string, string>()
        {
            {"last", "GremlinKeyword.Pop.last"},
            {"first", "GremlinKeyword.Pop.first"},
        };
    }

    public enum GremlinEdgeType
    {
        BothE,
        BothForwardE,
        InE,
        InForwardE,
        OutE
    }
}
