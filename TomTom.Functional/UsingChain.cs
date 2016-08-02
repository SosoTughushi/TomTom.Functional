namespace System
{
	public static class Disposable
	{
	
	//0 1 
		public static void UsingChain<T0,T1>(Func<T0> creator0,Func<T0,T1> creator1, Action<T0,T1> action)
			where T0 : IDisposable
			where T1 : IDisposable
					
		{
			UsingChain(creator0,creator1,(t0,t1)=>
			{
				action(t0,t1);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1, TResult>(Func<T0> creator0,Func<T0,T1> creator1, Func<T0,T1,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				
				return function(t0,t1);
			}
			finally
			{
					if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
		
	//0 0 2 	
	//0 1 2 
		public static void UsingChain<T0,T1,T2>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2, Action<T0,T1,T2> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,(t0,t1,t2)=>
			{
				action(t0,t1,t2);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2, Func<T0,T1,T2,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0,t1);
				
				return function(t0,t1,t2);
			}
			finally
			{
					if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2, Action<T0,T1,T2> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,(t0,t1,t2)=>
			{
				action(t0,t1,t2);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2, Func<T0,T1,T2,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0,t1);
				
				return function(t0,t1,t2);
			}
			finally
			{
					if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
		
	//0 0 0 3 	
	//0 1 0 3 	
	//0 0 1 3 	
	//0 1 1 3 	
	//0 0 2 3 	
	//0 1 2 3 
		public static void UsingChain<T0,T1,T2,T3>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3, Action<T0,T1,T2,T3> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,(t0,t1,t2,t3)=>
			{
				action(t0,t1,t2,t3);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3, Func<T0,T1,T2,T3,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2();
				t3 = creator3(t0,t1,t2);
				
				return function(t0,t1,t2,t3);
			}
			finally
			{
					if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3, Action<T0,T1,T2,T3> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,(t0,t1,t2,t3)=>
			{
				action(t0,t1,t2,t3);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3, Func<T0,T1,T2,T3,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2();
				t3 = creator3(t0,t1,t2);
				
				return function(t0,t1,t2,t3);
			}
			finally
			{
					if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3, Action<T0,T1,T2,T3> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,(t0,t1,t2,t3)=>
			{
				action(t0,t1,t2,t3);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3, Func<T0,T1,T2,T3,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0);
				t3 = creator3(t0,t1,t2);
				
				return function(t0,t1,t2,t3);
			}
			finally
			{
					if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3, Action<T0,T1,T2,T3> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,(t0,t1,t2,t3)=>
			{
				action(t0,t1,t2,t3);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3, Func<T0,T1,T2,T3,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0);
				t3 = creator3(t0,t1,t2);
				
				return function(t0,t1,t2,t3);
			}
			finally
			{
					if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3, Action<T0,T1,T2,T3> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,(t0,t1,t2,t3)=>
			{
				action(t0,t1,t2,t3);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3, Func<T0,T1,T2,T3,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0,t1);
				t3 = creator3(t0,t1,t2);
				
				return function(t0,t1,t2,t3);
			}
			finally
			{
					if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3, Action<T0,T1,T2,T3> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,(t0,t1,t2,t3)=>
			{
				action(t0,t1,t2,t3);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3, Func<T0,T1,T2,T3,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0,t1);
				t3 = creator3(t0,t1,t2);
				
				return function(t0,t1,t2,t3);
			}
			finally
			{
					if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
		
	//0 0 0 0 4 	
	//0 1 0 0 4 	
	//0 0 1 0 4 	
	//0 1 1 0 4 	
	//0 0 2 0 4 	
	//0 1 2 0 4 	
	//0 0 0 1 4 	
	//0 1 0 1 4 	
	//0 0 1 1 4 	
	//0 1 1 1 4 	
	//0 0 2 1 4 	
	//0 1 2 1 4 	
	//0 0 0 2 4 	
	//0 1 0 2 4 	
	//0 0 1 2 4 	
	//0 1 1 2 4 	
	//0 0 2 2 4 	
	//0 1 2 2 4 	
	//0 0 0 3 4 	
	//0 1 0 3 4 	
	//0 0 1 3 4 	
	//0 1 1 3 4 	
	//0 0 2 3 4 	
	//0 1 2 3 4 
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2();
				t3 = creator3();
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2();
				t3 = creator3();
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0);
				t3 = creator3();
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0);
				t3 = creator3();
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0,t1);
				t3 = creator3();
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0,t1);
				t3 = creator3();
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2();
				t3 = creator3(t0);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2();
				t3 = creator3(t0);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0);
				t3 = creator3(t0);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0);
				t3 = creator3(t0);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0,t1);
				t3 = creator3(t0);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0,t1);
				t3 = creator3(t0);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2();
				t3 = creator3(t0,t1);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2();
				t3 = creator3(t0,t1);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0);
				t3 = creator3(t0,t1);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0);
				t3 = creator3(t0,t1);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0,t1);
				t3 = creator3(t0,t1);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0,t1);
				t3 = creator3(t0,t1);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2();
				t3 = creator3(t0,t1,t2);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2();
				t3 = creator3(t0,t1,t2);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0);
				t3 = creator3(t0,t1,t2);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0);
				t3 = creator3(t0,t1,t2);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1();
				t2 = creator2(t0,t1);
				t3 = creator3(t0,t1,t2);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	
		public static void UsingChain<T0,T1,T2,T3,T4>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Action<T0,T1,T2,T3,T4> action)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
					
		{
			UsingChain(creator0,creator1,creator2,creator3,creator4,(t0,t1,t2,t3,t4)=>
			{
				action(t0,t1,t2,t3,t4);
				return 0;
			});
		}

		public static TResult UsingChain<T0,T1,T2,T3,T4, TResult>(Func<T0> creator0,Func<T0,T1> creator1,Func<T0,T1,T2> creator2,Func<T0,T1,T2,T3> creator3,Func<T0,T1,T2,T3,T4> creator4, Func<T0,T1,T2,T3,T4,TResult> function)
			where T0 : IDisposable
			where T1 : IDisposable
			where T2 : IDisposable
			where T3 : IDisposable
			where T4 : IDisposable
			        
		{
			var t0 = default(T0);
			var t1 = default(T1);
			var t2 = default(T2);
			var t3 = default(T3);
			var t4 = default(T4);	

			try
			{
				t0 = creator0();
				t1 = creator1(t0);
				t2 = creator2(t0,t1);
				t3 = creator3(t0,t1,t2);
				t4 = creator4(t0,t1,t2,t3);
				
				return function(t0,t1,t2,t3,t4);
			}
			finally
			{
					if(!(Equals(t4,default(T4))))
					{
						t4.Dispose();
					}
					else{
						if(!(Equals(t3,default(T3))))
					{
						t3.Dispose();
					}
					else{
						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t2,default(T2))))
					{
						t2.Dispose();
					}
					else{
						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t1,default(T1))))
					{
						t1.Dispose();
					}
					else{
						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}						if(!(Equals(t0,default(T0))))
					{
						t0.Dispose();
					}
			}			}
		}
	}
	
}

