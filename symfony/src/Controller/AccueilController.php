<?php

namespace App\Controller;

use App\Entity\Traversee;
use App\Form\TraverseRechercheType;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

class AccueilController extends AbstractController
{


    /**
     * @Route("/", name="home")
     */
    public function home(Request $request) {
        $traversee = new Traversee();
        
        $form = $this->createForm(TraverseRechercheType::class, $traversee);
        $form->handleRequest($request);

        $traversees = $this->getDoctrine()->getManager()->getRepository(Traversee::class)->getAll();

        return $this->render('accueil/accueil.html.twig', array('form'=> $form->createView(), 'traversees' => $traversees));
    }

}
