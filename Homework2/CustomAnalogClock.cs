using Android.Content;
using Android.Util;
using Android.Runtime;

using Com.Turki.Vectoranalogclockview;

namespace Homework2 {

    [Register("Homework2.CustomAnalogClock", DoNotGenerateAcw = true)]

    class CustomAnalogClock : VectorAnalogClock {

        // Implement constructors as insructed in docs
        public CustomAnalogClock(Context c) : base(c) {
            InitializeSimple();
        }

        public CustomAnalogClock(Context c, IAttributeSet aset) : base(c, aset) {
            InitializeSimple();
        }

        public CustomAnalogClock(Context c, IAttributeSet aset, int style) : base(c, aset, style) {
            InitializeSimple();
        }

        public CustomAnalogClock(Context c, IAttributeSet aset, int style, int res) : base(c, aset, style, res) {
            InitializeSimple();
        }

    }
}