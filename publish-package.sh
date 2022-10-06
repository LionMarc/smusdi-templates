#!/bin/sh

display_help() {
    echo "Usage: $0 [-h] [--notag] <version> <output-folder> " >&2
    echo
    echo "   <version>         the version of the package of the fome x.y.z"
    echo "   <output-folder>   this script publishes the package into a local folder, not a remote registry."
    echo
    echo "   -h          show this help text"
    echo "   --notag     if set, no git tag is created"
    echo
    exit 1
}

notag=false;
while getopts :h-: flag
do
    case "${flag}" in
        h) 
            display_help;
            exit;
            ;;
        -) 
            if [ "${OPTARG}" = "notag" ] 
            then notag=true 
            fi
        ;;
    esac
done
shift $((OPTIND-1))

version=$1
outputFolder=$2

dotnet pack Smusdi.Templates.csproj -p:PackageVersion=$1 -o $2

if [ ! ${notag} ]
then
    echo tagging version...
    git tag $1
fi