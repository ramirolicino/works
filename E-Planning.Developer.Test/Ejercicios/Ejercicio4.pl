binmode(STDOUT, "encoding(cp850)");
binmode(STDIN, "encoding(cp850)");

use strict;
use warnings;



sub Rot_13
{
    my($texto, $opcion) = @_;

    chomp $texto;
    my @asciich;

    while($texto =~ m/(.)/g)
    {   
        push @asciich,ord ($1);
    }
    
    my $cant = scalar(@asciich);

    for(my $i=0;$i<$cant;$i++)
    {
        if (($asciich[$i] >= 65 && $asciich[$i] <= 77)|| ($asciich[$i] >= 97 && $asciich[$i] <= 109))
        {
            $asciich[$i] = $asciich[$i]+13;
        }
        else
        {
            $asciich[$i] = $asciich[$i] - 13;
        }
    }
    
    foreach(my $i=0;$i<$cant;$i++)
    {
         $asciich[$i]=chr($asciich[$i]);
    }

    if($opcion == 8)
    {
        print "CIFRADO--> @asciich\t";
    }
    elsif ($opcion == 9) 
    {
        print "DESCIFRADO--> @asciich\t";
    }
}


sub EscribirArchivo
{
    my ($archivo, $texto) = @_;

        open(ARCHIVO, '>', $archivo);

        my $contenido = $texto;

        print ARCHIVO $contenido;
        print ARCHIVO Rot_13($contenido, 8);

        close(ARCHIVO);
}

sub LeerArchivo
{
    my ($archivo) = @_;

    open(ARCHIVO, '<', $archivo);
    
    print "mostrando contenido...\n";

    while(<ARCHIVO>)
    {
        print $_;
    }

    close(ARCHIVO);
}

sub MenuArchivo
{
    my($archivo, $opcion, $texto) = @_;

    if($opcion == 1)
    {
       EscribirArchivo($archivo, $texto);
    }
    if($opcion == 2)
    {
       LeerArchivo($archivo);
    }
    else
    {
        return "Opcion Invalida";
    }

}





print "Opcion \n1-abrirArchivo\n2-leerArchivo\n";
my $opcion = <STDIN>;
my $archivo = "pruebasa.txt";
my $nombre = "ramiro";
# my $cifrado = "enzveb";

MenuArchivo($archivo, $opcion, $nombre);

# Rot_13($cifrado, 9);
# Rot_13($nombre, 8);


exit;