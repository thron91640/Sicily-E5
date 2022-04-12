<?php

use Twig\Environment;
use Twig\Error\LoaderError;
use Twig\Error\RuntimeError;
use Twig\Extension\SandboxExtension;
use Twig\Markup;
use Twig\Sandbox\SecurityError;
use Twig\Sandbox\SecurityNotAllowedTagError;
use Twig\Sandbox\SecurityNotAllowedFilterError;
use Twig\Sandbox\SecurityNotAllowedFunctionError;
use Twig\Source;
use Twig\Template;

/* rechercher/index.html.twig */
class __TwigTemplate_3e8857da8868a06b4f82d61ebd747d50 extends Template
{
    private $source;
    private $macros = [];

    public function __construct(Environment $env)
    {
        parent::__construct($env);

        $this->source = $this->getSourceContext();

        $this->blocks = [
            'title' => [$this, 'block_title'],
            'content' => [$this, 'block_content'],
        ];
    }

    protected function doGetParent(array $context)
    {
        // line 1
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = [])
    {
        $macros = $this->macros;
        $__internal_5a27a8ba21ca79b61932376b2fa922d2 = $this->extensions["Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension"];
        $__internal_5a27a8ba21ca79b61932376b2fa922d2->enter($__internal_5a27a8ba21ca79b61932376b2fa922d2_prof = new \Twig\Profiler\Profile($this->getTemplateName(), "template", "rechercher/index.html.twig"));

        $__internal_6f47bbe9983af81f1e7450e9a3e3768f = $this->extensions["Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension"];
        $__internal_6f47bbe9983af81f1e7450e9a3e3768f->enter($__internal_6f47bbe9983af81f1e7450e9a3e3768f_prof = new \Twig\Profiler\Profile($this->getTemplateName(), "template", "rechercher/index.html.twig"));

        $this->parent = $this->loadTemplate("base.html.twig", "rechercher/index.html.twig", 1);
        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_5a27a8ba21ca79b61932376b2fa922d2->leave($__internal_5a27a8ba21ca79b61932376b2fa922d2_prof);

        
        $__internal_6f47bbe9983af81f1e7450e9a3e3768f->leave($__internal_6f47bbe9983af81f1e7450e9a3e3768f_prof);

    }

    // line 3
    public function block_title($context, array $blocks = [])
    {
        $macros = $this->macros;
        $__internal_5a27a8ba21ca79b61932376b2fa922d2 = $this->extensions["Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension"];
        $__internal_5a27a8ba21ca79b61932376b2fa922d2->enter($__internal_5a27a8ba21ca79b61932376b2fa922d2_prof = new \Twig\Profiler\Profile($this->getTemplateName(), "block", "title"));

        $__internal_6f47bbe9983af81f1e7450e9a3e3768f = $this->extensions["Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension"];
        $__internal_6f47bbe9983af81f1e7450e9a3e3768f->enter($__internal_6f47bbe9983af81f1e7450e9a3e3768f_prof = new \Twig\Profiler\Profile($this->getTemplateName(), "block", "title"));

        echo "Rechercher";
        
        $__internal_6f47bbe9983af81f1e7450e9a3e3768f->leave($__internal_6f47bbe9983af81f1e7450e9a3e3768f_prof);

        
        $__internal_5a27a8ba21ca79b61932376b2fa922d2->leave($__internal_5a27a8ba21ca79b61932376b2fa922d2_prof);

    }

    // line 5
    public function block_content($context, array $blocks = [])
    {
        $macros = $this->macros;
        $__internal_5a27a8ba21ca79b61932376b2fa922d2 = $this->extensions["Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension"];
        $__internal_5a27a8ba21ca79b61932376b2fa922d2->enter($__internal_5a27a8ba21ca79b61932376b2fa922d2_prof = new \Twig\Profiler\Profile($this->getTemplateName(), "block", "content"));

        $__internal_6f47bbe9983af81f1e7450e9a3e3768f = $this->extensions["Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension"];
        $__internal_6f47bbe9983af81f1e7450e9a3e3768f->enter($__internal_6f47bbe9983af81f1e7450e9a3e3768f_prof = new \Twig\Profiler\Profile($this->getTemplateName(), "block", "content"));

        // line 6
        echo "

<div class=\"container bg-light border rounded mt-5\">
    <br>
    <div class=\"row pt m-1\">

        <div class=\"col-md-3\">
            <label>Port de départ :</label>
            <select required>
            ";
        // line 15
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable((isset($context["portDepart"]) || array_key_exists("portDepart", $context) ? $context["portDepart"] : (function () { throw new RuntimeError('Variable "portDepart" does not exist.', 15, $this->source); })()));
        foreach ($context['_seq'] as $context["_key"] => $context["ports"]) {
            // line 16
            echo "            <option>";
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, $context["ports"], "name", [], "any", false, false, false, 16), "html", null, true);
            echo "</option>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['ports'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 18
        echo "            </select>
        </div>

        <div class=\"col-md-3\">
            <label>Port d'arrivée :</label>
            <select required>
            ";
        // line 24
        $context['_parent'] = $context;
        $context['_seq'] = twig_ensure_traversable((isset($context["portDepart"]) || array_key_exists("portDepart", $context) ? $context["portDepart"] : (function () { throw new RuntimeError('Variable "portDepart" does not exist.', 24, $this->source); })()));
        foreach ($context['_seq'] as $context["_key"] => $context["ports"]) {
            // line 25
            echo "            <option>";
            echo twig_escape_filter($this->env, twig_get_attribute($this->env, $this->source, $context["ports"], "name", [], "any", false, false, false, 25), "html", null, true);
            echo "</option>
            ";
        }
        $_parent = $context['_parent'];
        unset($context['_seq'], $context['_iterated'], $context['_key'], $context['ports'], $context['_parent'], $context['loop']);
        $context = array_intersect_key($context, $_parent) + $_parent;
        // line 27
        echo "            </select>
        </div>

        <div class=\"col-md-3\">
            <label>Date :</label>
            <input type=\"date\" required>
        </div>
    </div>
    <div class=\"row pt m-1\">
        <br>
        <div class=\"col-md-3\">
            <label>Nombre de passagers :</label>
            <input type=\"number\" placeholder=\"Nombre de passagers\" required>
        </div>

        <div class=\"col-md-3\">
            <label>Véhicule :</label>
            <input type=\"\" placeholder=\"\" required>
        </div>

        <div class=\"col-md-3\">
            <label>Aller-Retour :</label>
            <input type=\"\" placeholder=\"\" required>
        </div>

    </div>
    <div class=\"row pt m-1\">

        <div class=\"col-md-4\">
            <label>Heure :</label>
            <input type=  placeholder=\"\" required>
        </div>
        <div class=\"col-md-4\">
            <label>Type de passagers :</label>
            <select required>
            <option></option>
            </select>
        </div>
        <div class=\"col-md-4\">
            <label>Type de véhicules :</label>
            <select required>
            <option></option>
            </select>
        </div>
        
    </div>
    <div class=\"row pt m-1\">

        <div class=\"col-md-6\">
            <label>Date de retour :</label>
            <!--<input type=\"date\"  placeholder=\"\">-->
            <select required>
            <option></option>
            </select>
        </div>
        <div class=\"col-md-6\">
            <label>Heure de retour :</label>
            <select required>
            <option></option>
            </select>
        </div>
        
    </div><br>
    <center><input type=\"submit\" value=\"Rechercher\" min=\"1\" required></center>
    <br>
</div>
";
        
        $__internal_6f47bbe9983af81f1e7450e9a3e3768f->leave($__internal_6f47bbe9983af81f1e7450e9a3e3768f_prof);

        
        $__internal_5a27a8ba21ca79b61932376b2fa922d2->leave($__internal_5a27a8ba21ca79b61932376b2fa922d2_prof);

    }

    public function getTemplateName()
    {
        return "rechercher/index.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  133 => 27,  124 => 25,  120 => 24,  112 => 18,  103 => 16,  99 => 15,  88 => 6,  78 => 5,  59 => 3,  36 => 1,);
    }

    public function getSourceContext()
    {
        return new Source("{% extends 'base.html.twig' %}

{% block title %}Rechercher{% endblock %}

{% block content %}


<div class=\"container bg-light border rounded mt-5\">
    <br>
    <div class=\"row pt m-1\">

        <div class=\"col-md-3\">
            <label>Port de départ :</label>
            <select required>
            {% for ports in portDepart %}
            <option>{{ports.name}}</option>
            {% endfor %}
            </select>
        </div>

        <div class=\"col-md-3\">
            <label>Port d'arrivée :</label>
            <select required>
            {% for ports in portDepart %}
            <option>{{ports.name}}</option>
            {% endfor %}
            </select>
        </div>

        <div class=\"col-md-3\">
            <label>Date :</label>
            <input type=\"date\" required>
        </div>
    </div>
    <div class=\"row pt m-1\">
        <br>
        <div class=\"col-md-3\">
            <label>Nombre de passagers :</label>
            <input type=\"number\" placeholder=\"Nombre de passagers\" required>
        </div>

        <div class=\"col-md-3\">
            <label>Véhicule :</label>
            <input type=\"\" placeholder=\"\" required>
        </div>

        <div class=\"col-md-3\">
            <label>Aller-Retour :</label>
            <input type=\"\" placeholder=\"\" required>
        </div>

    </div>
    <div class=\"row pt m-1\">

        <div class=\"col-md-4\">
            <label>Heure :</label>
            <input type=  placeholder=\"\" required>
        </div>
        <div class=\"col-md-4\">
            <label>Type de passagers :</label>
            <select required>
            <option></option>
            </select>
        </div>
        <div class=\"col-md-4\">
            <label>Type de véhicules :</label>
            <select required>
            <option></option>
            </select>
        </div>
        
    </div>
    <div class=\"row pt m-1\">

        <div class=\"col-md-6\">
            <label>Date de retour :</label>
            <!--<input type=\"date\"  placeholder=\"\">-->
            <select required>
            <option></option>
            </select>
        </div>
        <div class=\"col-md-6\">
            <label>Heure de retour :</label>
            <select required>
            <option></option>
            </select>
        </div>
        
    </div><br>
    <center><input type=\"submit\" value=\"Rechercher\" min=\"1\" required></center>
    <br>
</div>
{% endblock %}
", "rechercher/index.html.twig", "/var/www/html/projetSicily/templates/rechercher/index.html.twig");
    }
}
