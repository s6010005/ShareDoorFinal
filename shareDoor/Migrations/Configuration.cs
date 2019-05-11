using shareDoor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace shareDoor.Migrations
{
   
    internal sealed class Configuration : DbMigrationsConfiguration<shareDoor.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }



        protected override void Seed(shareDoor.Data.ApplicationDbContext context)
        {

            //context.Roles.AddOrUpdate(x => x.Name,
            //    new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //    {
            //        Name = "Admin"
            //    },
            //    new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //    {
            //        Name = "Member"
            //    },
            //    new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //    {
            //        Name = "Silver Member"
            //    } ,
            //    new Microsoft.AspNet.Identity.EntityFramework.IdentityRole()
            //    {
            //        Name = "Gold Member"
            //    });

            //    context.States.AddOrUpdate(x => x.Id,

            //new Models.State

            //{
            //    Name = "�����-������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "��������-�������"},
            //        new Area(){Name = "���� ������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����������"},
            //        new Area(){Name = "��� �������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "����� - ������������-���������"},
            //        new Area(){Name = "����� - ������ �����"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������� ������"},
            //        new Area(){Name = "�������� - ����������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "����-������������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"}

            //    }

            //},

            //new Models.State

            //{
            //    Name = "�����-������ ��������",
            //    Areas = new List<Area>()
            //     {
            //        new Area(){Name = "����� ��������"},
            //        new Area(){Name = "���� ���������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "��� ������"},
            //        new Area(){Name = "������ ������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},


            //     }

            //},

            //new Models.State

            //{

            //    Name = "�����-����� ��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����� ���������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����������"},
            //        new Area(){Name = "����-�������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�����������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "��� ������"},
            //        new Area(){Name = "������ ������"},
            //        new Area(){Name = "�������"}


            //    }

            //},

            //new Models.State

            //{

            //    Name = "�����-������ ��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "���� �������"},
            //        new Area(){Name = "����� ���������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������� - ������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�����������"},
            //        new Area(){Name = "��� �����"},
            //        new Area(){Name = "��� �����������"},
            //        new Area(){Name = "��� ���������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "����������"}

            //    }
            //},
            //new Models.State

            //{

            //    Name = "�����-��������� ��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "����� ����"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "��� �����"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "����������"}

            //    }
            //},
            //new Models.State

            //{
            //    Name = "��������� ������-��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����� ������������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "��� �������"},
            //        new Area(){Name = "������ ������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "����� �������"},
            //        new Area(){Name = "����� �����"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"}

            //    }
            //},
            //new Models.State

            //{

            //    Name = "������ ������- ��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��� ������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "����"}

            //    }
            //},

            //new Models.State

            //{

            //    Name = "��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���� �����"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������ ��������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "����� ������� - ������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{

            //    Name = "����������� -������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����� ���������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��� ������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "����"},
            //        new Area(){Name = "�������������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���� ������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�������������������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������ ������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "��� �������"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "����������� - �����/��� �����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "�����������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "��������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "����������� - ����.�����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����� ���������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "���������"}

            //    }
            //},
            //new Models.State

            //{
            //    Name = "�.����������������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "���������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "�������"}
            //    }
            //},
            //new Models.State

            //{
            //    Name = "�.�����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "���"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����"},
            //        new Area(){Name = "���������"}

            //    }
            //},
            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������������"},
            //        new Area(){Name = "���������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "���"},
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.����������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "���������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����"},
            //        new Area(){Name = "�������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.����������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�����������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "���"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "����������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "���������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.�������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.����������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.����",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.���������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "��������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "����� ��������"},
            //        new Area(){Name = "���������"},
            //        new Area(){Name = "������"}

            //    }
            //},

            //new Models.State

            //{
            //    Name = "�.������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "��� �������"},
            //         new Area(){Name = "���������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "�����"},
            //         new Area(){Name = "������"},
            //        new Area(){Name = "���"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "����� �������������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "������"},
            //        new Area(){Name = "�����"},
            //         new Area(){Name = "�������"},
            //        new Area(){Name = "����"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "��������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�������"},
            //         new Area(){Name = "��������"}
            //    }
            //},

            //new Models.State

            //{
            //    Name = "������",
            //    Areas = new List<Area>()
            //    {
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "�������"},
            //        new Area(){Name = "��������"},
            //        new Area(){Name = "�����"},
            //        new Area(){Name = "����������"}
            //    }
            //});
        }
    }
}
