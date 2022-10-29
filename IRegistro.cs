// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System.IO;

interface IRegistro
{
    void LerRegistro(BinaryReader arquivo, long qualRegistro);
    void GravarRegistro(BinaryWriter arquivo);
    int TamanhoRegistro { get; }
}