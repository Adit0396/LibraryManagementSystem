using System;
using static System.Console;

namespace Assignment
{
    //The specification of MemberCollection ADT, which is used to store and manipulate a collection of members

    interface iMemberCollection
    {
        int number // get the number of members in the community library
        {
            get;
        }
        void add(iMember aMember); //add a new member to this member collection, make sure there are no duplicates in the member collection

        void delete(iMember aMember); //delete a given member from this member collection, a member can be deleted only when the member currently is not holding any tool

        Boolean search(iMember aMember); //search a given member in this member collection. Return true if this memeber is in the member collection; return false otherwise

        void clear(); // remove all the members in this member collection

        iMember[] toArray(); //output the members into an array of iMember 

    }
    class MemberCollection:iMemberCollection
    {

        static iMember[] member = new iMember[5];
		public int number{ get { return member.Length-1; } }   
        
        public void add(iMember aMember) {
            for (int i = 0; i <= member.Length; i++)
            {
                if (member[i] == null && member[i + 1]==null)
                {
                    member[i] = aMember;
                    break;
                }
                else
                    continue;
            }
        }
        public void delete(iMember aMember)
        {
            for (int i = 0; i <= member.Length - 1; i++)
            {
                if (member[i] != null)
                {
                    if (member[i].FirstName == aMember.FirstName)
                    {
                        member[i] = null;
                    }
                    else
                        continue;    
                }
                else
                    break; ;
            }
        }
		public Boolean search(iMember aMember)
		{
            for (int i = 0; i <= member.Length - 1; i++)
            {
                if (member[i].FirstName == aMember.FirstName)
                return true;
                    
            }
            return false;
        }
		public void clear() {
            for (int i = 0; i <= member.Length - 1; i++)
                member[i] = null;
        }   
        public void display()
        {
            for (int i =0; i<= member.Length-1;i++)
            {
                if(member[i]!=null)
                WriteLine(member[i]);
            }       
        }
        public string getConnectPhone(string firstname, string lastname)
		{
            for (int i = 0; i <= member.Length - 1; i++)
            {
                if (member[i].FirstName == firstname &&
                    member[i].LastName == lastname)
                    return member[i].ContactNumber;
            }
            return "0";
        }
         public iMember[] toArray()
         {
            return member;
         }

    }
}


