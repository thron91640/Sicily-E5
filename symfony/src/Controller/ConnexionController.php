<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\Form\Extension\Core\Type\TextType;
use Symfony\Component\Form\Extension\Core\Type\PasswordType;
use Symfony\Component\Form\Extension\Core\Type\ChoiceType;
use Symfony\Component\Form\Extension\Core\Type\SubmitType;
use Symfony\Component\Form\Extension\Core\Type\ResetType;
use Symfony\Component\Form\Extension\Core\Type\EmailType;
use App\Entity\User;

class ConnexionController extends AbstractController
{
    /**
     * @Route("/connexionold", name="app_connexion")
     */
    public function connexionForm()
    {
        $form = $this->createFormBuilder()
            ->add('login', TextType::class)
            ->add('password', PasswordType::class)
            ->add('Valider', SubmitType::class)
            ->getForm();
        
        $request = Request::createFromGlobals();
        $form->handleRequest($request);

        if($form->isSubmitted() && $form->isValid())
        {
            $data = $form->getData();
            return $this->render('connexion/form_to_connect_submit.html.twig', array('data'=>$data));
        }
        return $this->render('connexion/form_to_connect.html.twig', ['form'=>$form->createView()]);
    }

    /**
     * @Route("/incription", name="app_inscription")
     */
    public function inscriptionForm(Request $request)
    {
        $user = new User();
        $form = $this->createFormBuilder()
            ->add('email', EmailType::class)
            ->add('password', PasswordType::class)
            ->add('username', TextType::class)
            ->add('Valider', SubmitType::class)
            ->getForm();

            $form->handleRequest($request);
            if($form->isSubmitted() && $form->isValid())
            {
                return $this->render('connexion/form_to_inscription_submit.html.twig', array('user'=>$user));
            }
            return $this->render('connexion/form_to_inscription.html.twig', array('form'=>$form->createView()));
    }

    
}
