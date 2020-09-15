using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static partial class CommonUtils
{
    public class ReqComputeShader
    {
        ComputeShader cs;
        Dictionary<string, CBufferList> dictCB = new Dictionary<string, CBufferList>();
        Dictionary<string, int> str2iKernel = new Dictionary<string, int>();

        public int GetKernel(string _strKernel)
        {
            int iKernel = 0;
            if (!str2iKernel.TryGetValue(_strKernel, out var kernel))
            {
                iKernel = cs.FindKernel(_strKernel);
                str2iKernel.Add(_strKernel, iKernel);
            }
            return iKernel;
        }

        public struct CBufferList
        {
            public ComputeBuffer cb;
            public IList list;
        }

        /// <summary>
        /// it from resources
        /// </summary>
        /// <param name="computeShaderName"></param>
        public ReqComputeShader(string computeShaderName)
        {
            cs = Resources.Load<ComputeShader>("Compute/"+computeShaderName);
            if(cs == null)
            {
                cs = Resources.Load<ComputeShader>(computeShaderName);
            }
        }

        public CBufferList SetBuffer<T>(string key, List<T> list)
        {
            if(!dictCB.TryGetValue(key, out var cbl))
            {
                cbl = new CBufferList();
                cbl.cb = new ComputeBuffer(list.Count, CommonUtils.GetByteSize<T>());
                dictCB.Add(key, cbl);
            }
            return cbl;
        }

        public void Dispatch(string kernelName, int x, int y, int z)
        {
            //set datas

            cs.Dispatch(GetKernel(kernelName), x, y, z);
        }
    }
    

    
}
