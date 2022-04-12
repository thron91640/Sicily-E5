<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class ReserverController extends AbstractController
{

    public function index(): Response
    {
        return $this->render('reserver/index.html.twig', [
            'controller_name' => 'ReserverController',
        ]);
    }
}
