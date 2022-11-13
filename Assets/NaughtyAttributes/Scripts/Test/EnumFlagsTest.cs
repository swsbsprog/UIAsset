using UnityEngine;

namespace NaughtyAttributes.Test
{
    public enum TestEnum
    {
        None = 0,
        B = 1 << 0,
        C = 1 << 1,
        D = 1 << 2,
        E = 1 << 3,
        F = 1 << 4,
        All = ~0
    }

    public class EnumFlagsTest : MonoBehaviour
    {
        public TestEnum defaultEnum; // 동시 선택 불가.

        [EnumFlags]
        public TestEnum flags0;

        public EnumFlagsNest1 nest1;

        [Button]
        void TestFn()
        {
            print(@$"flags0에는 B가 포함되어 있는가? : {flags0.HasFlag(TestEnum.B)}
flags0:{flags0}" );
        }
    }

    [System.Serializable]
    public class EnumFlagsNest1
    {
        [EnumFlags]
        public TestEnum flags1;

        public EnumFlagsNest2 nest2;
    }

    [System.Serializable]
    public class EnumFlagsNest2
    {
        [EnumFlags]
        public TestEnum flags2;
    }
}
