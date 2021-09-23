using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; /// 


namespace GErbechCollector
{
    unsafe public class UIntArray : IDisposable
    {
        bool isDispouset;
        int* array = null;
        public int Lengs { get; set; }
        public UIntArray(int length)
        {
            Lengs = length;
            array = (int*)Marshal.AllocHGlobal(Lengs * Marshal.SizeOf<int>());
            GC.AddMemoryPressure(Lengs * Marshal.SizeOf<int>());
        }
        public int this[int index] {
                get => array[index];
                set => array[index] = value;
                }
        ~UIntArray() {
            Clean(false);
        }

        protected void Clean(bool userDispouse) {
            if (!isDispouset) {
                Marshal.FreeHGlobal((IntPtr)array);
                GC.RemoveMemoryPressure(Lengs * sizeof(int));
                if (userDispouse) {
                    Lengs = 0;
                
                }
             

                isDispouset = true;
            }
        }
        public void Dispose()
        {
            Clean(true);
            GC.SuppressFinalize(this);
            
        }
    }
}
