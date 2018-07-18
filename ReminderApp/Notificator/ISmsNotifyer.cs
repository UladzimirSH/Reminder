namespace Notificator {
    public interface ISmsNotifyer {
        void NotifyByPhoneNumber(string phoneNumber, string message);
    }
}
