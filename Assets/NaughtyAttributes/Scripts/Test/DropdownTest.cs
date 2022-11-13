using UnityEngine;
using System.Collections.Generic;

namespace NaughtyAttributes.Test
{
    public class DropdownTest : MonoBehaviour
    {
        [Dropdown("intValues")]
        public int intValue;


        [Dropdown("GetHeroNames")]
        public int heroType;

#pragma warning disable 414
        private int[] intValues = new int[] { 1, 2, 3 };

        private DropdownList<int> GetHeroNames()
        {
            return new DropdownList<int>()
            {
                { "조조", 2 },
                { "유비", 3 },
                { "관우", 4 }
            };
        }
#pragma warning restore 414

        public DropdownNest1 nest1;
    }

    [System.Serializable]
    public class DropdownNest1
    {
        [Dropdown("StringValues")]
        public string stringValue;

        private List<string> StringValues { get { return new List<string>() { "A", "B", "C" }; } }

        public DropdownNest2 nest2;
    }

    [System.Serializable]
    public class DropdownNest2
    {
        [Dropdown("GetVectorValues")]
        public Vector3 vectorValue;

        private DropdownList<Vector3> GetVectorValues()
        {
            return new DropdownList<Vector3>()
            {
                { "Right", Vector3.right },
                { "Up", Vector3.up },
                { "Forward", Vector3.forward }
            };
        }
    }
}
