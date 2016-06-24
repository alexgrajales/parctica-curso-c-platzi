namespace institucion.Modelo
{
     interface IEnteInstituto
    {
        string CogigoInterno { get; set; }
        string ConstruirLLaveSecreta(string nombreEnte);
    }
}