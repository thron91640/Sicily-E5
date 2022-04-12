<?php

namespace App\Controller;

use App\Entity\Traversee;
use App\Form\TraverseeType;
use App\Repository\TraverseeRepository;
use Doctrine\ORM\EntityManagerInterface;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

/**
 * @Route("/traversee")
 */
class TraverseeController extends AbstractController
{
    /**
     * @Route("/", name="app_traversee_index", methods={"GET"})
     */
    public function index(TraverseeRepository $traverseeRepository): Response
    {
        return $this->render('traversee/index.html.twig', [
            'traversees' => $traverseeRepository->findAll(),
        ]);
    }

    /**
     * @Route("/new", name="app_traversee_new", methods={"GET", "POST"})
     */
    public function new(Request $request, EntityManagerInterface $entityManager): Response
    {
        $traversee = new Traversee();
        $form = $this->createForm(TraverseeType::class, $traversee);
        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $entityManager->persist($traversee);
            $entityManager->flush();

            return $this->redirectToRoute('app_traversee_index', [], Response::HTTP_SEE_OTHER);
        }

        return $this->render('traversee/new.html.twig', [
            'traversee' => $traversee,
            'form' => $form->createView(),
        ]);
    }

    /**
     * @Route("/{id}", name="app_traversee_show", methods={"GET"})
     */
    public function show(Traversee $traversee): Response
    {
        return $this->render('traversee/show.html.twig', [
            'traversee' => $traversee,
        ]);
    }

    /**
     * @Route("/{id}/edit", name="app_traversee_edit", methods={"GET", "POST"})
     */
    public function edit(Request $request, Traversee $traversee, EntityManagerInterface $entityManager): Response
    {
        $form = $this->createForm(TraverseeType::class, $traversee);
        $form->handleRequest($request);

        if ($form->isSubmitted() && $form->isValid()) {
            $entityManager->flush();

            return $this->redirectToRoute('app_traversee_index', [], Response::HTTP_SEE_OTHER);
        }

        return $this->render('traversee/edit.html.twig', [
            'traversee' => $traversee,
            'form' => $form->createView(),
        ]);
    }

    /**
     * @Route("/{id}", name="app_traversee_delete", methods={"POST"})
     */
    public function delete(Request $request, Traversee $traversee, EntityManagerInterface $entityManager): Response
    {
        if ($this->isCsrfTokenValid('delete'.$traversee->getId(), $request->request->get('_token'))) {
            $entityManager->remove($traversee);
            $entityManager->flush();
        }

        return $this->redirectToRoute('app_traversee_index', [], Response::HTTP_SEE_OTHER);
    }
}
