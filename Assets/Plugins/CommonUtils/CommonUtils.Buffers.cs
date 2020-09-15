using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// buffers for compute buffer
/// </summary>
public static partial class CommonUtils
{    
    public static class TriangleMethod
    {
        public static bool IsContain(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 targetPos)
        {
            //y 무시
            v1.y = 0;
            v2.y = 0;
            v3.y = 0;
            targetPos.y = 0;

            //백터의 외적을 통해, 왼쪽에있는지 오른쪽에 있는지 알 수있다.
            //두 백터의 외적값은 백터이다.
            //두 백터의 크기와 관계있으며 그 두 백터에 수직인 백터가 생성된다.

            var vDirL =  (v2 - v1).normalized;
            var vDirT_R = (targetPos - v1).normalized;
            var isL = IsLeftSide(ref vDirL, ref vDirT_R);
            if (isL)
                return false;

            vDirL = (v3 - v2).normalized;
            vDirT_R = (targetPos - v2).normalized;
            isL = IsLeftSide(ref vDirL, ref vDirT_R);
            if (isL)
                return false;

            vDirL = (v1 - v3).normalized;
            vDirT_R = (targetPos - v3).normalized;
            isL = IsLeftSide(ref vDirL, ref vDirT_R);
            if (isL)
                return false;

            return true;
        } 
        
        private static bool IsLeftSide(ref Vector3 dirLeft, ref Vector3 dirRight)
        {
            var crossVector = Vector3.Cross(dirLeft, dirRight);
            return crossVector.y < 0;
        }
    }     
}
