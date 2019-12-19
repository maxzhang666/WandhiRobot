/*
 *	�˴����� T4 ������� MenuExport.tt ģ������, �������˽����´�����ô�, �����޸�!
 *	
 *	���ļ�������Ŀ Json �ļ��Ĳ˵���������.
 */
using System;
using System.Runtime.InteropServices;
using System.Text;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using Unity;

namespace Native.Csharp.App.Core
{
    public class MenuExport
    {
		#region --���캯��--
		/// <summary>
		/// ��̬���캯��, ע������ע��ص�
		/// </summary>
        static MenuExport ()
        {
			// �ַ�Ӧ�����¼�
			ResolveAppbackcall ();
        }
        #endregion

		#region --˽�з���--
		/// <summary>
		/// ��ȡ���е�ע����, �ַ�����Ӧ���¼�
		/// </summary>
		private static void ResolveAppbackcall ()
		{
			/*
			 * Name: ��������
			 * Function: _menuA
			 */
			if (Common.UnityContainer.IsRegistered<ICallMenu> ("��������") == true)
			{
				Menu__menuA = Common.UnityContainer.Resolve<ICallMenu> ("��������").CallMenu;
			}


		}
        #endregion

		#region --��������--
		/*
		 * Name: ��������
		 * Function: _menuA
		 */
		public static event EventHandler<CqCallMenuEventArgs> Menu__menuA;
		[DllExport (ExportName = "_menuA", CallingConvention = CallingConvention.StdCall)]
		private static int Evnet__menuA ()
		{
			if (Menu__menuA != null)
			{
				Menu__menuA (null, new CqCallMenuEventArgs ("��������"));
			}
			return 0;
		}


		#endregion
    }
}

