using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBookSlotsApp
{
    public class Wheel
    {
        private float startVelocity = 0;
        private float defaultAccelleration = 5;
        private float defaultDecelleration = 2;
        private float defaultNameSize = 50;
        private float defaultspinSpeed = 100;
        
        
        public float Velocity {  get; private set; }
        public float TargetSpeed { get; set; }
        public float DecellerationSpeed { get; set; }
        public float AccellerationSpeed { get; set; }
        public float NameSize { get; set; }
        public float SpinSpeed { get; set; }
        public float Pointer { get; private set; }
        
        public float Length
        {
            get
            {
                return NameSize * Names.Count;
            }
            private set
            {
               new InvalidOperationException("this property cannot be directly adjusted, change NameSize or the Names list");
            }
        }

        public string NamePointedAt
        {
            get
            {
                int index = Convert.ToInt32(Pointer / NameSize);
                return names[index];
            }
            set
            {
                new InvalidOperationException("this property cannot be directly adjusted (cheater)");
            }
        }

        private List<string> names = new List<string>() ;
        public List<String> Names {
            get
            {
                return names;
            }
            private set {
                names = value;
            }
        }

        public Wheel(List<string> names)
        {
            Velocity = startVelocity;
            TargetSpeed = Velocity;
            AccellerationSpeed = defaultAccelleration;
            DecellerationSpeed = defaultDecelleration;
            SpinSpeed = defaultspinSpeed;
            
            Names = names;
            NameSize = defaultNameSize;
        }

        public void Start()
        {
            TargetSpeed = SpinSpeed;
        }

        public void Stop()
        {
            TargetSpeed = 0;
        }

        public void Tick(float timePassed)
        {
            AdjustVelocity(timePassed);
            AdjustPointer(timePassed);
        }

        private void AdjustPointer(float timePassed) {      
            Pointer += Velocity * timePassed;
            if (Pointer >= Length)
            {
                Pointer -= Length;
            }
        }

        private void AdjustVelocity(float timePassed)
        {
            switch (TargetSpeed > Velocity)
            {
                case true:
                    Velocity += AccellerationSpeed * timePassed;
                    break;
                case false:
                    Velocity -= DecellerationSpeed * timePassed;
                    break;
            }
            if (Velocity > SpinSpeed)
            {
                Velocity = SpinSpeed;
            }
        }


    }
}
