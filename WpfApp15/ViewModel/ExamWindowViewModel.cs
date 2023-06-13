using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp15.ViewModel
{
    class Study
    {
        private String _patientID;
        public String PatientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        private String _patientName;
        public String PatientName
        {
            get { return _patientID; }
            set
            {
                _patientName = value;
            }
        }

        private String _sex;
        public String Sex
        {
            get { return _sex; }
            set
            {
                _sex = value;
            }
        }

        private String _accession;
        public String Accession
        {
            get { return _accession; }
            set
            {
                _accession = value;
            }
       }

        private String _studyDate;
        public String StudyDate
        {
            get { return _studyDate; }
            set
            {
                _studyDate = value;
            }
        }

        private String _studyTime;
        public String StudyTime
        {
            get { return _studyTime; }
            set
            {
                _studyTime = value;
            }
        }

        private String _numImages;
        public String NumImages
        {
            get { return _numImages; }
            set
            {
                _numImages = value;
            }
        }

        private String _studyDescription;
        public String StudyDescription
        {
            get { return _studyDescription; }
            set
            {
                _studyDescription = value;
            }   
        }

    }


     class ExamWindowViewModel:ViewModelBase
    {
        ObservableCollection<Study> _studys;

        public ObservableCollection<Study> Studys
        {
            get { return _studys; }
        }


        public ExamWindowViewModel()
        {
            _studys = new ObservableCollection<Study>();
            _studys.Add(new Study() { PatientID = "0333244", PatientName = "Mike", Sex = "Male" ,Accession="AB09433",StudyDate="20230612",NumImages="10",StudyDescription="Cardiac Stress Echo"});
            _studys.Add(new Study() { PatientID = "0333431", PatientName = "Sara", Sex = "Female", Accession="AB09434",StudyDate="20230613",NumImages="15",StudyDescription="OB 12 weeks General" });
        }

    }

   
}
