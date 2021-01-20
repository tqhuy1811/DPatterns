
/*
 One of actually useful pattern. Works great with legacy system. Notice this pattern make use of type inheritance and composition
*/
namespace DesignPattern
{
    interface LightningPhone
    {
        void Recharge();
        void UseLightning();
    }

    interface MicroUsbPhone
    {
        void Recharge();
        void UseMicroUsb();
    }

    class Iphone : LightningPhone
    {
        private bool connector;


        public void UseLightning()
        {
            connector = true;
        }


        public void Recharge()
        {
            if (connector)
            {

            }
            else
            {

            }
        }
    }
    class Android : MicroUsbPhone
    {
        public void Recharge()
        {

        }

        public void UseMicroUsb()
        {

        }
    }

    class LightningToMicroUsbAdapter : MicroUsbPhone
    {
        private LightningPhone lightningPhone;

        public LightningToMicroUsbAdapter(LightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }


        public void UseMicroUsb()
        {
            lightningPhone.UseLightning();
        }


        public void Recharge()
        {
            lightningPhone.Recharge();
        }
    }
}