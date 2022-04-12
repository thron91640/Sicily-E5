<?php

namespace App\Controller;

use App\Repository\PortRepository;
use App\Repository\LiaisonRepository;
use App\Entity\Port;
use App\Entity\Liaison;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class RechercherController extends AbstractController
{

    public function index(PortRepository $portRepository): Response
    {

        $portDepart=$portRepository->findAll();

        return $this->render('rechercher/index.html.twig', [
            'portDepart' => $portDepart
        ]);
    }
}
