using System;

namespace TomTom.Functional
{
    public static class Functional
    {
        #region Pipe
        public static T1 Pipe<T1>(this T1 input,Action<T1> action)
        {
            action(input);
            return input;
        }

        public static Action<T1> Pipe<T1, T2>(this T2 input, Func<T1, Action<T2>> func)
            => a => func(a)(input);
        

        public static TResult Pipe<T1, TResult>(this T1 input, Func<T1, TResult> func)
            => func(input);

        public static Func<T1, TResult> Pipe<T1, T2, TResult>(this T2 lastParameter, Func<T1, T2, TResult> func)
            => lastParameter.Pipe(func.Pipe(Curry));

        public static Func<T1, TResult> Pipe<T1, T2, TResult>(this T2 lastParameter, Func<T1, Func<T2, TResult>> func)
            => a => func(a)(lastParameter);

        public static Func<T1, Func<T2, TResult>> Pipe<T1, T2, T3, TResult>(this T3 lastParameter, Func<T1, Func<T2, Func<T3, TResult>>> func)
            => a => b => func(a)(b)(lastParameter);

        public static Func<T1, Func<T2, TResult>> Pipe<T1, T2, T3, TResult>(this T3 lastParameter, Func<T1, T2, T3, TResult> func)
            => lastParameter.Pipe(func.Pipe(Curry));

        public static Func<T1, Func<T2, Func<T3, TResult>>> Pipe<T1, T2, T3, T4, TResult>(this T4 lastParameter, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> func)
            => a => b => c => func(a)(b)(c)(lastParameter);

        public static Func<T1, Func<T2, Func<T3, TResult>>> Pipe<T1, T2, T3, T4, TResult>(this T4 lastParameter, Func<T1, T2, T3, T4, TResult> func)
            => lastParameter.Pipe(func.Pipe(Curry));


        #endregion

        #region reverse
        public static Func<T2, Func<T1, TResult>> Reverse<T1, T2, TResult>(Func<T1, Func<T2, TResult>> func) => a => b => func(b)(a);
        public static Func<T3, Func<T2, Func<T1, TResult>>> Reverse<T1, T2, T3, TResult>(Func<T1, Func<T2, Func<T3, TResult>>> func) => a => b => c => func(c)(b)(a);
        public static Func<T4, Func<T3, Func<T2, Func<T1, TResult>>>> Reverse<T1, T2, T3, T4, TResult>(Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> func) => a => b => c => d => func(d)(c)(b)(a);
        
            
        #endregion

        #region slide
        public static Func<T3, Func<T1, Func<T2, TReturn>>> SlideRight<T1, T2, T3, TReturn>(Func<T1, Func<T2, Func<T3, TReturn>>> func)
            => c => a => b => func(a)(b)(c);
        public static Func<T2, Func<T3, Func<T1, TReturn>>> SlideLeft<T1, T2, T3, TReturn>(Func<T1, Func<T2, Func<T3, TReturn>>> func)
            => b => c => a => func(a)(b)(c);
        public static Func<T4, Func<T1, Func<T2, Func<T3, TReturn>>>> SlideRight<T1, T2, T3, T4, TReturn>(Func<T1, Func<T2, Func<T3, Func<T4, TReturn>>>> func)
            => d => a => b => c => func(a)(b)(c)(d);
        public static Func<T2, Func<T3, Func<T4, Func<T1, TReturn>>>> SlideLeft<T1, T2, T3, T4, TReturn>(Func<T1, Func<T2, Func<T3, Func<T4, TReturn>>>> func)
            => b => c => d => a => func(a)(b)(c)(d);
        #endregion

        #region parse
        public static Func<T1, T2, T3, TResult> Parse<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func) => func;
        public static Func<T1, T2, T3, T4, TResult> Parse<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> func) => func;
        public static Func<T1, T2, TResult> Parse<T1, T2, TResult>(Func<T1, T2, TResult> func) => func;
        public static Func<T1, TResult> Parse<T1, TResult>(Func<T1, TResult> func) => func;
        #endregion

        #region curry
        public static Func<T1, Action<T2>> Curry<T1, T2>(Action<T1, T2> action)
            => a => b => action(a, b);
        public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(Action<T1, T2, T3> action)
            => a => b => c => action(a, b, c);
        public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curry<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
            => a => b => c => d => action(a, b, c, d);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curry<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
            => a => b => c => d => e => action(a, b, c, d, e);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curry<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action)
            => a => b => c => d => e => f => action(a, b, c, d, e, f);
        public static Func<T1, Func<T2, TR>> Curry<T1, T2, TR>(Func<T1, T2, TR> func)
            => a => b => func(a, b);
        public static Func<T1, Func<T2, Func<T3, TR>>> Curry<T1, T2, T3, TR>(Func<T1, T2, T3, TR> func)
            => a => b => c => func(a, b, c);
        public static Func<T1, Func<T2, Func<T3, Func<T4, TR>>>> Curry<T1, T2, T3, T4, TR>(Func<T1, T2, T3, T4, TR> func)
            => a => b => c => d => func(a, b, c, d);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TR>>>>> Curry<T1, T2, T3, T4, T5, TR>(System.Func<T1, T2, T3, T4, T5, TR> func)
            => a => b => c => d => e => func(a, b, c, d, e);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TR>>>>>> Curry<T1, T2, T3, T4, T5, T6, TR>(System.Func<T1, T2, T3, T4, T5, T6, TR> func)
            => a => b => c => d => e => f => func(a, b, c, d, e, f);
        #endregion
    }
}
