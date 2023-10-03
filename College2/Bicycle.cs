using College2.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace College2
{
    public class Bicycle
    {
        private SlotType _slot;
        private ColorType _color;
        private BikeType _bikeType;
        private double _frameHeight;
        private double _range;
        
        private bool _isLocked;

        public double FrameHeight
        {
            get => this._frameHeight;
            set => this._frameHeight = value;
        }

        public SlotType Slot
        {
            get => this._slot;
            set => this._slot = value;
        }

        public ColorType Color
        {
            get => this._color;
            set => this._color = value;
        }

        public BikeType BikeType
        {
            get => this._bikeType;
            set => this._bikeType = value;
        }

        public double RangeInKilometers
        {
            get => this._range;
            set => this._range = value;
        }

        public double RangeInMiles
        {
            get => 0.621371192 * this._range;
            set => this._range = 1.60934 * value;
        }


        public void Lock()
        {
            this._isLocked = true;
        }

        public void Unlock()
        {
            this._isLocked = false;
        }

        public string Print()
        {
            return $"Slot: {this.Slot}" +
                $"\nFrame Hoogte: {this.FrameHeight}" +
                $"\nColor: {this.Color}" +
                $"\nIs Locked: {this._isLocked}" +
                $"\nBike type: {this.BikeType}";
        }
    }
}
