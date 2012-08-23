﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoggyConsole.Controls
{
    /// <summary>
    /// Base class for all ControlDrawers
    /// </summary>
    public abstract class ControlDrawer
    {
        private Control _control;

        /// <summary>
        /// The Control which should be drawn
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the Control which should be set already has an other Drawer assigned</exception>
        public Control Control
        {
            get { return _control; }
            set
            {
                if(value.Drawer != null && value.Drawer != this)
                    throw new ArgumentException("Control already has a Drawer assigned", "value");
                _control = value;
            }
        }


        /// <summary>
        /// Creates a new ControlDrawer
        /// </summary>
        /// <param name="control">The Control to draw</param>
        public ControlDrawer(Control control = null)
        {
            Control = control;
        }

        /// <summary>
        /// Draws the Control stored in the Control-Property
        /// </summary>
        /// <param name="leftOffset">Offset for the left value (used to convert local coordinates within a container to global ones)</param>
        /// <param name="topOffset">Offset for the top value (used to convert local coordinates within a container to global ones)</param>
        /// <param name="boundary">The boundary of the <code>ContainerControl</code> in which the <code>Control</code> is placed</param>
        public abstract void Draw(int leftOffset, int topOffset, Rectangle boundary);
    }
}