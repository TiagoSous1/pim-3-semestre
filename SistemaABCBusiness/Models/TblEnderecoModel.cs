using SistemaABCBusiness.ValueObjects;
using SistemaABCDAO.Entities;
using SistemaABCDAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCBusiness.Models
{

    public class TblEnderecoModel
    {
        private readonly TblEnderecoRepository tblEnderecoRepository = new TblEnderecoRepository();
        public int? idAddress { get; set; }
        public string street { get; set; }
        public int? number { get; set; }
        public string codeZip { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string nmState { get; set; }
        public EntityState State { get; private set; }

        public TblEnderecoModel()
        {
        }

        public TblEnderecoModel(int? idAddress, string street, int? number, string codeZip, string neighborhood, string city, string nmState)
        {
            this.idAddress = idAddress;
            this.street = street;
            this.number = number;
            this.codeZip = codeZip;
            this.neighborhood = neighborhood;
            this.city = city;
            this.nmState = nmState;
        }


        public string saveChange()
        {
            string message = "";

            try
            {
                TblEnderecoDAO tblEndenrecoDataRepository = new TblEnderecoDAO
                {
                    idAddress = idAddress,
                    neighborhood = neighborhood,
                    nmState = nmState,
                    number = number,
                    street = street,
                    city = city,
                    codeZip = codeZip
                };

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        tblEnderecoRepository.Add(tblEndenrecoDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        tblEnderecoRepository.Edit(tblEndenrecoDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        tblEnderecoRepository.Remove((int)idAddress);
                        message = "Usuário removido com sucesso!";
                        break;
                }

                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<TblEnderecoModel> GetAll()
        {
            try
            {
                var listTblEndereco = new List<TblEnderecoModel>();
                var tblEnderecoDataModel = tblEnderecoRepository.GetAll();

                foreach (TblEnderecoDAO item in tblEnderecoDataModel)
                {
                    listTblEndereco.Add(new TblEnderecoModel
                    {
                        city = item.city,
                        idAddress = item.idAddress,
                        codeZip = item.codeZip,
                        street = item.street,
                        neighborhood = item.neighborhood,
                        nmState = item.nmState,
                        number = item.number                        
                    });
                }
                return listTblEndereco;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblEnderecoModel> GetSelectEndereco(int idAddress)
        {
            try
            {
                var listTblEndereco = new List<TblEnderecoModel>();
                var tblEnderecoDataModel = tblEnderecoRepository.GetSelectEndereco(idAddress);

                foreach (TblEnderecoDAO item in tblEnderecoDataModel)
                {
                    listTblEndereco.Add(new TblEnderecoModel
                    {
                        city = item.city,
                        idAddress = item.idAddress,
                        codeZip = item.codeZip,
                        street = item.street,
                        neighborhood = item.neighborhood,
                        nmState = item.nmState,
                        number = item.number
                    });
                }
                return listTblEndereco;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
