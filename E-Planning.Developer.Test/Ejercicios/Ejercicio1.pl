use strict;
use warnings;


sub Ordenamiento 
{
    my ($palabra) = @_;
    $palabra = join "", sort split //, shift;
    $palabra =~ s/^\s+//;
    $palabra =~ s/\s+$//;
    return $palabra;
}

sub ContarCaracteresString
{
    my ($palabra) = @_;

    my $cantidad = map $_, $palabra =~ /(.)/gs;
    return $cantidad;
}

sub SonAnagramas
{
    my($p1, $p2) = @_;

    if(ContarCaracteresString($p1) != ContarCaracteresString($p2) &&
      (Ordenamiento($p1) ne Ordenamiento($p2)))
    {
        return "No son anagramas";
    }
    else
    {
        return "Son Anagramas";
    }
}


my $palabra1 = "roma";
my $palabra2 = "amfor";

print SonAnagramas($palabra1, $palabra2);


exit;