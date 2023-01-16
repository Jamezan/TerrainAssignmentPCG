using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialsBuilder
{
    private List<Material> materialsList = new List<Material>();

    public MaterialsBuilder(){

        Material redMaterial = new Material(Shader.Find("Specular"));
        redMaterial.color = Color.red;

        Material whiteMaterial = new Material(Shader.Find("Specular"));
        whiteMaterial.color = Color.white;

        Material greenMaterial = new Material(Shader.Find("Specular"));
        greenMaterial.color = Color.green;

        Material yellowMaterial = new Material(Shader.Find("Specular"));
        yellowMaterial.color = Color.yellow;

        Material magentaMaterial = new Material(Shader.Find("Specular"));
        magentaMaterial.color = Color.magenta;

        Material blackMaterial = new Material(Shader.Find("Specular"));
        blackMaterial.color = Color.black;

        materialsList.Add(redMaterial);
        materialsList.Add(whiteMaterial);
        materialsList.Add(greenMaterial);
        materialsList.Add(yellowMaterial);
        materialsList.Add(magentaMaterial);
        materialsList.Add(blackMaterial);
    }

    public List<Material> MaterialsList(){
        return materialsList;
    }

}
