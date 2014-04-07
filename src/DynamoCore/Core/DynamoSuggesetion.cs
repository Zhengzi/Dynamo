using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dynamo.Models;

namespace Dynamo.Core
{
    class DynamoSuggesetion
    {
        public static List<NodeModel> AddModel(NodeModel node)
        {
            var ns = new List<NodeModel>();
            var n1 = DynamoModel.CreateNodeInstance("Number");
            var n2 = DynamoModel.CreateNodeInstance("Number"); 
            var n3 = DynamoModel.CreateNodeInstance("Number");
            DetermineLocation(n1);
            ns.Add(n1);
            ns.Add(n2); ns.Add(n3);
            return ns;
        }

        private static void DetermineLocation(NodeModel node)
        {
            return;
        }

        private static NodeModel getNodeModel(NodeModel node)
        {
            return null;
        }
    }
}
