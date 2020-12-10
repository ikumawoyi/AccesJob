using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccessJob.Models
{
	public class Apply
	{
		public int Id { get; set; }
		public string Title { get; set; }
		[Display(Name = "First name")]
		public string FirstName { get; set; }
		[Display(Name = "Last name")]
		public string LastName { get; set; }
		[Display(Name = "Contact address")]
		public string ContactAddress { get; set; }
		[Display(Name = "Email Address")]
		public string Email { get; set; }
		[Display(Name = "Position")]
		public string PositionApplyingFor { get; set; }
		[Display(Name = "Can you work in the UK")]
		public string CanYouWorkInTheUK { get; set; }
		[Display(Name = "Mobile number")]
		public string MobileNumber { get; set; }
		[Display(Name = "Postal code")]
		public string PostalCode { get; set; }
		[Display(Name = "Years of experience")]
		public int YearsOfExperience { get; set; }
		[Display(Name = "Personal identification number")]
		public string PIN { get; set; }
		[Display(Name = "PIN expiry date")]
		public DateTime? PINExpiryDate { get; set; }
		[Display(Name = "National identification number")]
		public string NIN { get; set; }
		[Display(Name = "Date of birth")]
		public DateTime DateOfBirth { get; set; }

		[Display(Name = "Next of kin names")]
		public string NextOfKinNames { get; set; }
		[Display(Name = "Relationship")]
		public string NextOfKinRelationship { get; set; }
		[Display(Name = "Address")]
		public string NextOfKinAddress { get; set; }
		[Display(Name = "Phone number")]
		public string NextOfKinPhoneNumber { get; set; }

		[Display(Name = "Company Name")]
		public string FirstEmploymentCompanyName { get; set; }
		[Display(Name = "Company address")]
		public string FirstEmploymentCompanyAddress { get; set; }
		[Display(Name = "Your position")]
		public string FirstEmploymentPosition { get; set; }
		[Display(Name = "Your responsibility")]
		public string FirstEmploymentResponsibilities { get; set; }
		[Display(Name = "Reason for leaving")]
		public string FirstEmploymentReasonForLeaving { get; set; }
		[Display(Name = "Start date")]
		public DateTime? FirstEmploymentDateFrom { get; set; }
		[Display(Name = "End date")]
		public DateTime? FirstEmploymentDateTo { get; set; }

		[Display(Name = "Company Name")]
		public string SecondEmploymentCompanyName { get; set; }
		[Display(Name = "Company address")]
		public string SecondEmploymentCompanyAddress { get; set; }
		[Display(Name = "Your position")]
		public string SecondEmploymentPosition { get; set; }
		[Display(Name = "Your responsibility")]
		public string SecondEmploymentResponsibilities { get; set; }
		[Display(Name = "Reason for leaving")]
		public string SecondEmploymentReasonForLeaving { get; set; }
		[Display(Name = "Start date")]
		public DateTime? SecondEmploymentDateFrom { get; set; }
		[Display(Name = "End date")]
		public DateTime? SecondEmploymentDateTo { get; set; }


		[Display(Name = "Company Name")]
		public string ThirdEmploymentCompanyName { get; set; }
		[Display(Name = "Company address")]
		public string ThirdEmploymentCompanyAddress { get; set; }
		[Display(Name = "Your position")]
		public string ThirdEmploymentPosition { get; set; }
		[Display(Name = "Your responsibility")]
		public string ThirdEmploymentResponsibilities { get; set; }
		[Display(Name = "Reason for leaving")]
		public string ThirdEmploymentReasonForLeaving { get; set; }
		[Display(Name = "Start date")]
		public DateTime? ThirdEmploymentDateFrom { get; set; }
		[Display(Name = "End date")]
		public DateTime? ThirdEmploymentDateTo { get; set; }

		[Display(Name = "Qualification")]
		public string FirstQualification { get; set; }
		[Display(Name = "Institution")]
		public string FirstAwardingInstitution { get; set; }
		[Display(Name = "Date of award")]
		public DateTime? FirstDateAwarded { get; set; }

		[Display(Name = "Qualification")]
		public string SecondQualification { get; set; }
		[Display(Name = "Institution")]
		public string SecondAwardingInstitution { get; set; }
		[Display(Name = "Date of award")]
		public DateTime? SecondDateAwarded { get; set; }

		[Display(Name = "Qualification")]
		public string ThirdQualification { get; set; }
		[Display(Name = "Institution")]
		public string ThirdAwardingInstitution { get; set; }
		[Display(Name = "Date of award")]
		public DateTime? ThirdDateAwarded { get; set; }

		[Display(Name = "Immunization Name")]
		public string ImmunizationName { get; set; }
		[Display(Name = "Date administered")]
		public DateTime? DateAdministered { get; set; }
		public string Convicted { get; set; }

		[Display(Name = "Committed crime")]
		public string TypeOfCrime { get; set; }
		public string Disabled { get; set; }

		[Display(Name = "Disability")]
		public string TypeOfDisability { get; set; }

		[Display(Name = "Registered with other agent?")]
		public string RegisteredWithOtherAgents { get; set; }

		[Display(Name = "Name of other agent")]
		public string NameOfAgent { get; set; }


		[Display(Name = "Name of referee")]
		public string FirstRefereeNames { get; set; }
		[Display(Name = "Name of referee")]
		public string SecondRefereeNames { get; set; }
		[Display(Name = "How did u know us?")]
		public string HowDidYouKnowAboutUs { get; set; }
	}
}
