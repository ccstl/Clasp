﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotionCtrl;
using System.Threading;
namespace clasp
{
    class WS
    {
    }
    public static class WsTest
    {
        public static bool is_need_turn = false;//正反向模组判断
        public static EM_SYS_STA status;
         static void run()
        {
            
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(50);
            }
            status = EM_SYS_STA.STANDBY;
            ;
        }
        static Task TestTask = new Task(run);
        public static void RunTask()
        {
            if (TestTask == null || TestTask != null && TestTask.IsCompleted)
            {
                VAR.msg.AddMsg(Msg.EM_MSGTYPE.SYS, "创建测试线程");
                if (TestTask != null) TestTask.Dispose();
                TestTask = new Task(run);
                // brun = true;
                status = EM_SYS_STA.RUN;
                TestTask.Start();
                

            }

        }
    }
}
