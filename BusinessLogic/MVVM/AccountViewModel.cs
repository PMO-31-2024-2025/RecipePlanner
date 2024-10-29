using DataAccess;

namespace BusinessLogic.MVVM
{
    public class AccountViewModel : BaseViewModel
    {
        #region Fields
        private string _email = Globals.LoginedAccount.Email;
        private int _age = Globals.LoginedAccount.AccountInfo.Age;
        private Sex _gender = Globals.LoginedAccount.AccountInfo.Sex;
        private WeightGoal _goal = Globals.LoginedAccount.AccountInfo.Goal;
        private int _desiredWeight = Globals.LoginedAccount.AccountInfo.DesiredWeight;
        private int _currentWeight = Globals.LoginedAccount.AccountInfo.Weight;
        private int _height = Globals.LoginedAccount.AccountInfo.Height;
        #endregion

        #region Properties
        public string Email 
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            } 
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public Sex Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        public WeightGoal Goal
        {
            get
            {
                return _goal;
            }
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(Goal));
            }
        }
        public int DesiredWeight
        {
            get
            {
                return _desiredWeight;
            }
            set
            {
                _desiredWeight = value;
                OnPropertyChanged(nameof(DesiredWeight));
            }
        }
        public int CurrentWeight
        {
            get
            {
                return _currentWeight;
            }
            set
            {
                _currentWeight = value;
                OnPropertyChanged(nameof(CurrentWeight));
            }
        }
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }
        #endregion

        #region Commands

        #endregion

        #region Constructors
        #endregion

        #region Methods
        #endregion
    }
}
