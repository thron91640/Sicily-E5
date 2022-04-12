<?php

namespace App\Form;

use App\Entity\Traversee;
use Symfony\Component\Form\AbstractType;
use Symfony\Component\Form\FormBuilderInterface;
use Symfony\Component\OptionsResolver\OptionsResolver;
use Symfony\Component\Form\Extension\Core\Type\ChoiceType;

class TraverseRechercheType extends AbstractType
{
    public function buildForm(FormBuilderInterface $builder, array $options): void
    {
    $builder
    

    /**->add('date', ::class, [
        'choices' => [
            'Palerme' => 'palerme',
            'Messine'=> 'Messine',
            'stromboli'=> 'stromboli',
            'Panarea'=> 'Panarea',
        ]
    ]) */

;
}
    public function configureOptions(OptionsResolver $resolver): void
    {
        $resolver->setDefaults([
            'data_class' => Traversee::class,
        ]);
    }
}


