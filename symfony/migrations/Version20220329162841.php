<?php

declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20220329162841 extends AbstractMigration
{
    public function getDescription(): string
    {
        return '';
    }

    public function up(Schema $schema): void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->addSql('ALTER TABLE traversee CHANGE liaison_id liaison_id INT DEFAULT NULL');
        $this->addSql('ALTER TABLE traversee ADD CONSTRAINT FK_B688F501ED31185 FOREIGN KEY (liaison_id) REFERENCES liaison (id)');
        $this->addSql('CREATE INDEX IDX_B688F501ED31185 ON traversee (liaison_id)');
    }

    public function down(Schema $schema): void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->addSql('ALTER TABLE traversee DROP FOREIGN KEY FK_B688F501ED31185');
        $this->addSql('DROP INDEX IDX_B688F501ED31185 ON traversee');
        $this->addSql('ALTER TABLE traversee CHANGE liaison_id liaison_id INT NOT NULL');
    }
}
