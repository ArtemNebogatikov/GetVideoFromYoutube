using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVideoFromYoutube
{
    class VideoFromYoutube
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void Execute()
        {
            command.Run();
        }

    }
}
