namespace Task
{
    internal class ComplexNumber
        {
            // + ; new behavior : sum complex ! 

            public int Real { get; set; }
            public int Imag { get; set; }

            public ComplexNumber(int Real , int Imag)
            {
            this.Real = Real;
            this.Imag = Imag;
            }
        public ComplexNumber()
        {
            
        }
        public override string ToString()
            {
                return $"{Real} + {Imag}i";
            }



            //// operator Overloading : 
            //// must be non_private  static  operator   >> why? >> self
            public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
            {
                return new ComplexNumber()
                {
                    Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                    Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
                };
            }

            public static ComplexNumber operator*(ComplexNumber left , ComplexNumber right)
            {
                return new ComplexNumber()
                {
                    Real = (left?.Real ?? 0) * (right?.Real ?? 0),
                    Imag = (left?.Imag ?? 0) * (right?.Imag ?? 0)
                };
            }
            // Refactor : 
            // Dereferencing : Access Ref 
            //  Real = Left.Real is not null ? Left.Real : null;






            // Design : 
            // Refactor : 
            // Dereferencing : Access Ref 
            //  Real = Left.Real is not null ? Left.Real : null;
            //public static ComplexNumber operator+ (ComplexNumber left,ComplexNumber right)
            //{
            //    // teach him how to sum 
            //    return new ComplexNumber()
            //    {
            //        Real = (left?.Real??0) + (right?.Real??0),
            //        Imag = (left?.Imag??0) + (right?.Imag??0)
            //    };
            //}



            public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
            {
                // teach him how to minus 
                return new ComplexNumber()
                {
                    Real = left.Real - right.Real,
                    Imag = left.Imag - right.Imag
                };
            }
        }
}
