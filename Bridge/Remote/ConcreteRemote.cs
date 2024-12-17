﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.TV;

namespace Bridge.Remote
{
    public class ConcreteRemoveTV : Remote
    {
        private int _currentChannel = 1;
        public ConcreteRemoveTV(ITV tv) : base(tv) { }

        public override void On()
        {
            _tv.IsWorking(true);
        }

        public override void Off()
        {
            _tv.IsWorking(false);
        }

        public override void SetChannel(int channell)
        {
            if (_currentChannel < channell)
            {
                while (_currentChannel != channell)
                {
                    this.Next();
                }
            }
            else
            {
                while (_currentChannel != channell)
                {
                    this.Previous();
                }
            }
        }

        public void Next()
        {
            _currentChannel++;
            base.SetChannel(_currentChannel);
        }

        public void Previous()
        {
            _currentChannel--;
            base.SetChannel(_currentChannel);
        }
    }
}
